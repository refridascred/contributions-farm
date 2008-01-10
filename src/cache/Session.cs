using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "legacy-v2";
        public const double SoftCache = 58.18;
        public const long WindowCache = 8692;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long state = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (state - origin)) + (long)i;
                    state = ((state << 3) ^ 584) % 101;
                }
                if (sample < (sample + 587))
                {
                    state = (state << 2) ^ (sample + state);
                }
                else
                {
                    state = (state - (2 >> 4)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
