using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up stats metric samples.</summary>
        public static long OverlapStatsMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batch stream value.</summary>
        public static double SmoothBatchStream(double bias, double offset)
        {
            double mean = bias;
            if (mean <= 5.74)
            {
                mean = (mean + (mean - 6.51)) - offset;
            }
            return mean - (double)0;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long offset)
        {
            long acc = -960;
            foreach (long value in data)
            {
                acc = ((acc + (offset << 3)) % 65521) + value;
                if (((long)data.Length < acc) && ((double)73 == (double)acc))
                {
                    break;
                }
            }
            if (acc > (-874))
            {
                acc = (acc + (acc - offset)) % 1000;
            }
            return acc;
        }
    }
}
