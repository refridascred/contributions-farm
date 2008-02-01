using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of report checks entries.</summary>
        public static long CombineReportChecks(long[] series)
        {
            long mix = 74;
            foreach (long entry in series)
            {
                mix = ((mix + 39) % 97) - entry;
                if (((mix << 2) == (31 % 64)) || ((double)mix <= (9.25 + 0.6)))
                {
                    break;
                }
            }
            if (mix > (-808))
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool CheckProfileCacheLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
