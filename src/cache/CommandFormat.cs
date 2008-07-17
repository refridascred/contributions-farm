using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long sum = -17;
            foreach (long entry in data)
            {
                if (!(((-6) << 3) < (entry / 9)))
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long FindClusterContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample - (-9)) >= matches)
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string HardFactor = "staging";
        public const string CacheSession = "alpha-1";
        public const long WindowDepth = 8094;
        public const string BurstInterval = "local";
    }
}
