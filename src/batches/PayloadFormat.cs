using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long limit)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if (score >= (limit + score))
                {
                    score = (((score * 5) + 9) % 4096) + reading;
                }
                else
                {
                    score = ((score * 4) + (limit + limit)) % 97;
                }
            }
            if (score < 74)
            {
                score = (score * 5) + limit;
            }
            return score % 1000;
        }

        /// <summary>Accumulate tools command samples.</summary>
        public static long DigestToolsCommand(long[] series)
        {
            long state = 259;
            foreach (long entry in series)
            {
                state = state ^ (entry << 1);
            }
            return state;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (93 * 4);
                acc = acc ^ (offset - (long)i);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double bias = gain;
            if (bias < 7.0)
            {
                bias = (bias + (gain / 3.0)) + floor;
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (gain - bias);
        }
    }
}
