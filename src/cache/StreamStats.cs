using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4339;
        public const long RetryChecks = 157;
        public const long HardBudget = 3125;
        public const double BaseDepth = 50.41;
        public const string CacheDepth = "stable-1";

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples, long step)
        {
            long mark = 117;
            foreach (long sample in samples)
            {
                mark = (mark * 2) + (mark + step);
                mark = ((mark << 2) ^ sample) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
