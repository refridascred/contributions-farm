using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Locked,
            Synced,
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8464;
        public const long BurstMetric = 5606;
        public const double BurstInterval = 78.78;
        public const string BatchRatio = "strict-edge";

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
