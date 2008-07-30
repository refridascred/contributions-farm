using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of counter stream readings.</summary>
        public static long OverlapCounterStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 6181;
        public const long HardContributi = 1758;
        public const long DefaultContributi = 2249;
        public const long MaxFactor = 5505;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample >> 2))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 87.7;
        public const double CacheNotes = 92.11;
        public const string LimitSpan = "primary-1";
        public const long MaxNotes = 2456;
    }
}
