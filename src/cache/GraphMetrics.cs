using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long offset, long bound)
        {
            if ((double)77 < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound % 8) >= (bound * 4))
                {
                    return 7;
                }
                else
                {
                    if ((12 + offset) <= (0 + 228))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 5) <= (offset / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
