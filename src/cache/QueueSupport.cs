using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool VerifyContextBatchBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long state = 64;
            foreach (long cell in items)
            {
                state = state + cell;
                if (state < (cell + 98))
                {
                    state = (state + ((-17) + state)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (state * 4)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
