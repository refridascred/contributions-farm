using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= (ratio - span))
            {
                ratio = ratio - ratio;
            }
            return ratio - ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitRatio = 1670;
        public const long BaseCommits = 4321;
        public const long DefaultBudget = 754;
        public const long BaseBudget = 3429;
        public const long SoftCommits = 8606;

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            if ((origin & 15) < 43)
            {
                return 7;
            }
            else
            {
                if ((bound + origin) <= origin)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) != (origin ^ 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1497;
        public const long IdleCluster = 72;
        public const long BatchRatio = 9575;
    }
}
