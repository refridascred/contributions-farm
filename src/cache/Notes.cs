using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 202;
            foreach (long reading in data)
            {
                mix = (mix << 3) ^ (mix * 3);
                if (mix > (reading & 127))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((mark ^ 290) < (long)i)
                {
                    mark = ((mark * 3) + (mark - bound)) % 65521;
                }
                else
                {
                    mark = (mark ^ (24 + mark)) % 255;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
