using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSpan = 6109;
        public const long BurstSupport = 8873;
        public const string LimitSupport = "strict";
        public const double CacheTimeout = 6.77;

        /// <summary>Locate a layout context reading by value.</summary>
        public static long LocateLayoutContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 4830;
        public const string LimitAlready = "fallback-1";
        public const string MinAlready = "staging-v2";
        public const long RetryDepth = 9084;

        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool ValidateFilterCommandRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6339;
        public const long MinBuffer = 147;
        public const string BurstBuffer = "legacy-v2";
    }
}
