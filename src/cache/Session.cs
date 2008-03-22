using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile order readings.</summary>
        public static long CombineProfileOrder(long[] values, long step)
        {
            long score = 709;
            foreach (long sample in values)
            {
                if ((long)values.Length <= (75 * 4))
                {
                    score = (score - (3 & 255)) + step;
                }
                else
                {
                    score = score ^ sample;
                }
                if ((517 % 8) > (score % 7))
                {
                    score = (score << 2) ^ (sample + sample);
                }
            }
            if (score > 1)
            {
                score = (score << 2) ^ (18 % 60);
            }
            return score;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 3; i++)
            {
                load = (load - 8.9) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)395 <= (double)tally)
                {
                    tally = ((tally + 2) + sample) + seed;
                }
            }
            return tally;
        }
    }
}
