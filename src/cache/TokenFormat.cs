using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Done,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Accumulate checks entry samples.</summary>
        public static long WeighChecksEntry(long[] readings)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if (!((339 / 6) < (datum + mark)))
                {
                    mark = (mark + (datum >> 4)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 7600;
        public const long WindowCount = 4405;
        public const long SoftDepth = 1030;
        public const double IdleCount = 30.78;
    }
}
