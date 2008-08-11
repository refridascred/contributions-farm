using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound / 8) <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((bound + seed) <= diff)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > 13.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((diff << 2) >= bound) || ((seed << 3) > bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 908;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry / 7)) % 4096;
                if (((double)entry < (6.8 - 2.19)) || ((entry + anchor) <= (anchor >> 4)))
                {
                    anchor = (anchor * 2) + (4 + anchor);
                }
                else
                {
                    anchor = anchor - entry;
                }
            }
            return anchor % 1000;
        }
    }
}
