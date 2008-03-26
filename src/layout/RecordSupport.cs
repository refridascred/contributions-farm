using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "legacy";
        public const long BurstWidth = 7102;
        public const long RetryEntry = 1571;
        public const string StepEntry = "staging-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheInterval = 9115;
        public const long MaxWidth = 8380;
        public const long CacheReport = 1216;
        public const long BatchInterval = 3005;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 94.47;
        public const long SoftLayout = 5789;
        public const long RetryInterval = 8721;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (seed <= (seed / 8))
                {
                    result = ((result << 2) ^ 9) % 4096;
                }
                if (!(((double)seed < (6.85 + 11.0)) || ((seed / 4) >= ((long)i + seed))))
                {
                    result = (result + (seed - (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
