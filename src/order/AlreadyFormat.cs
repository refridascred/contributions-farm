using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 88.08;
        public const string StepInterval = "legacy-1";
        public const string BurstProfile = "primary-edge";
        public const long SoftTimeout = 1531;
        public const long IdleProfile = 164;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((218 + hits) > (cell % 10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur < (cur * 2))
            {
                return 6;
            }
            else
            {
                if ((origin / 6) <= (697 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((cur >> 4) <= (offset >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double bias)
        {
            double ratio2 = 4.7;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + bias;
            }
            else
            {
                ratio2 = ratio2 - (bias - ratio);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
