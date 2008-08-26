using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((seed & 7) >= seed)
            {
                return 6;
            }
            else
            {
                if (((seed << 3) <= (origin ^ seed)) || ((double)seed == (8.0 + 0.3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items, long floor)
        {
            long total = 8;
            foreach (long value in items)
            {
                total = ((((total << 3) ^ (3 ^ 4)) % 101) ^ value) - floor;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5654;
        public const double LimitBatches = 94.62;
        public const long WindowDepth = 7569;
        public const string LimitFactor = "standard-edge";
    }
}
