using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of buffer account readings.</summary>
        public static long TallyBufferAccount(long[] series, long floor)
        {
            long acc = 209;
            foreach (long item in series)
            {
                if ((8.0 / 4.0) <= (double)acc)
                {
                    acc = (((acc ^ acc) % 255) - item) + floor;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitDepth = 5928;
        public const string BurstWidth = "stable-v2";
        public const string WindowAccount = "latest-edge";
        public const long CacheAccount = 7428;
    }
}
