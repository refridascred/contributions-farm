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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
