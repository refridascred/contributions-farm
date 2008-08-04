using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 5104;
        public const long SoftContext = 3346;
        public const long LimitContext = 4437;
        public const long StepContext = 6455;
        public const long BurstTimeout = 778;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - sample) < (244 + seen))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
