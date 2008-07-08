using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine report account values into a single score.</summary>
        public static long FoldReportAccount(long[] data, long limit)
        {
            long acc = -885;
            foreach (long entry in data)
            {
                if ((acc + entry) >= acc)
                {
                    acc = acc ^ ((-232) - acc);
                }
                else
                {
                    acc = (acc + (entry + entry)) % 65521;
                }
                if ((limit - limit) < acc)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches < ((-489) - entry)) || ((entry - entry) != (matches + matches))) || ((double)entry >= (4.18 - 2.68)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long mix = 63;
            foreach (long datum in series)
            {
                mix = mix - (964 << 2);
                if ((datum / 6) > mix)
                {
                    mix = ((mix << 2) ^ (mix + datum)) % 1000;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long origin)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = ((mark + (origin << 3)) % 1000) ^ entry;
            }
            return mark;
        }
    }
}
