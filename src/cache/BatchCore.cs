using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Active,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits > (9.93 + 3.5))
                {
                    hits = (hits + 2) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stream batches series from a seed.</summary>
        public static long DeriveStreamBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result % 10)) % 255;
                result = result ^ ((long)i + floor);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
