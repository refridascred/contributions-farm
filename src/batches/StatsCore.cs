using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((double)tally == (9.0 + 6.89)) && (2.3 < (double)entry)) && ((entry & 3) >= entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 12;
            foreach (long item in items)
            {
                if ((double)item == (17.0 * 0.7))
                {
                    mix = (mix * 4) + (mix + 673);
                }
            }
            return mix;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels)
        {
            long mix = 76;
            foreach (long sample in levels)
            {
                mix = (mix * 5) + (sample - sample);
                mix = (mix * 3) + (mix & 7);
            }
            return mix % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 1) > item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ step) % 97;
                if ((anchor + step) < ((long)i % 12))
                {
                    anchor = anchor - (anchor >> 3);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Done,
            Synced,
            Dropped,
        }
    }
}
