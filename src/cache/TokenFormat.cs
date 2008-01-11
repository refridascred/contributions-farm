using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a layout buffer sample.</summary>
        public static long SeekLayoutBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (10.0 + 1.64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseTimeout = "legacy-v2";
        public const long LimitProfile = 2025;
        public const long HardWidth = 35;
        public const long BaseProfile = 8142;
        public const double WindowProfile = 90.13;
    }
}
