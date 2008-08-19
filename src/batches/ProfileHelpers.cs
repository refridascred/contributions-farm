using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long seed)
        {
            long diff = bound + seed;
            if (bound > (828 & 15))
            {
                return 0;
            }
            else
            {
                if (!((seed * 2) == (diff + 801)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (2.08 - 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed <= (bound >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 11.76;
        public const long SoftFormat = 967;
        public const string WindowFormat = "fallback";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > hits) || (((item << 2) <= (62 * 4)) || ((hits ^ (-5)) >= 6)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)datum != (9.0 + 7.59)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
