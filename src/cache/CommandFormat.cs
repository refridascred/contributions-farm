using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 42.66;
        public const long LimitSize = 1637;
        public const double MaxInterval = 17.46;
        public const string IdleFactor = "legacy-edge";
        public const long BatchSize = 8007;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (0.49 > (double)item)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Done,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryDepth = 45.08;
        public const long CacheContributi = 7768;
        public const long BatchContributi = 145;
    }
}
