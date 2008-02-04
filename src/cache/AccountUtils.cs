using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of payload tools readings.</summary>
        public static long ComparePayloadToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state ^ seed) ^ (long)i2;
                }
                if ((((-5) + seed) < (state % 12)) && ((double)state >= (double)seed))
                {
                    state = (state + seed) % 4096;
                }
                state = (state ^ state) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
