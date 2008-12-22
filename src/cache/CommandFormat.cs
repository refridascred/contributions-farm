using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long anchor = 226;
            foreach (long entry in series)
            {
                if ((3.5 * 8.8) == (double)anchor)
                {
                    anchor = ((anchor + 35) % 4096) - entry;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 8408;
        public const double RetryWindow = 33.92;
        public const string BaseSize = "cached";
        public const string MinLevel = "cached-1";
    }
}
