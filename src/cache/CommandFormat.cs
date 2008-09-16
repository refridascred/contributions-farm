using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSpan = "open-edge";
        public const long CacheToken = 6450;
        public const long IdleLevel = 4620;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ (bound - 4)) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            New,
            Ready,
            Stale,
        }
    }
}
