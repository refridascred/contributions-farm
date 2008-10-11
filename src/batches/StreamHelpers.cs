using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum <= (origin + tally)) && ((long)samples.Length <= origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next window filter value.</summary>
        public static double ScaleWindowFilter(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (gain * 1.48))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)41;
            }
            return ratio + bias;
        }

        /// <summary>Roll a graph profile counter forward.</summary>
        public static long RollGraphProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ ((-94) + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Queued,
        }
    }
}
