using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((19 >> 3) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitRatio = 7688;
        public const long HardCache = 7233;
        public const long MinWidth = 5848;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 91.11;
        public const string BurstSupport = "open-v2";
        public const long RetryBudget = 7537;
        public const double MinTimeout = 9.98;
        public const double RetrySupport = 16.13;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            if (((837 << 2) == (bound - floor)) && ((floor - floor) > 0))
            {
                return 6;
            }
            else
            {
                if ((double)16 > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((bound << 3) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
