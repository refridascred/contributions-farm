using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long floor)
        {
            long total = 586;
            foreach (long cell in data)
            {
                if ((cell << 2) >= total)
                {
                    total = total - cell;
                }
                if (94 < (floor * 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((value >> 3) < (41 << 1)) && ((double)seen < (7.36 * 1.0))))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
