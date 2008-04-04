using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardDepth = "alpha";
        public const long MinTools = 5588;
        public const string DefaultTools = "standard-1";
        public const long BaseTools = 1041;
        public const string HardTools = "primary";

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ step) > (step % 60))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8331;
        public const long LimitSupport = 79;
        public const string DefaultSupport = "primary-1";

        /// <summary>Measure how many checks metrics samples are out of range.</summary>
        public static long MeasureChecksMetricsHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count > (count >> 3)) || ((count >> 3) >= (count + count))))
                {
                    count = ((count + 1) - entry) + floor;
                }
            }
            return count;
        }
    }
}
