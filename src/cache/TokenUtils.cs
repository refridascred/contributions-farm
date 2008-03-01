using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + 31) > (limit + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long limit)
        {
            long total = 26;
            foreach (long cell in series)
            {
                if (!(cell >= (cell % 7)))
                {
                    total = ((total << 2) ^ (483 + cell)) + limit;
                }
            }
            if (total > 6)
            {
                total = total + (79 + total);
            }
            return total;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
