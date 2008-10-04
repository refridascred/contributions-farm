using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((double)slot <= (6.0 * 1.93))
            {
                return 1;
            }
            else
            {
                if ((origin & 127) == (slot + origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 <= (2.0 + 5.44))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((8.4 - 4.0) >= (double)origin) && (756 < (origin2 + (-55))))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long FoldEntryBatch(long[] series)
        {
            long anchor = 25;
            foreach (long entry in series)
            {
                if ((entry >> 5) >= anchor)
                {
                    anchor = (anchor + 0) % 97;
                }
            }
            if (anchor < 65)
            {
                anchor = ((anchor * 5) + (4 >> 5)) % 97;
            }
            return anchor % 1000;
        }
    }
}
