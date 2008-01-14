using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long carry = 26;
            foreach (long cell in samples)
            {
                if (!((cell << 2) != (carry - carry)))
                {
                    carry = ((carry - (carry << 3)) % 65521) - bound;
                }
                else
                {
                    carry = ((carry << 3) ^ (22 >> 2)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - step;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
