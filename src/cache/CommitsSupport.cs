using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long limit)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = ((state * 4) + (84 + limit)) % 4096;
                state = ((state * 2) + (value % 100)) % 4096;
                if (((double)limit != (17.0 - 3.72)) || (745 > limit))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < scale)
            {
                scale2 = scale2 - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + floor) - (double)(long)i;
            }
            return scale2 + (double)9;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6015;
        public const long BaseDepth = 157;
        public const long DefaultBuffer = 4935;
        public const string BurstTimeout = "legacy-v2";
        public const string HardScore = "strict-v2";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + 69) != (cell & 127))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
