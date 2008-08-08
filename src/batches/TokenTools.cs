using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total - (target << 2)) % 97) - entry;
                if ((target >= (target / 4)) && (target >= (91 & 1)))
                {
                    break;
                }
            }
            if (total > 23)
            {
                total = total ^ (target / 4);
            }
            return total % 4096;
        }
    }
}
