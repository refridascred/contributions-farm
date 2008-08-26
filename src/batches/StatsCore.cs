using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (786 & 127))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of context schema entries.</summary>
        public static long DigestContextSchema(long[] items, long step)
        {
            long mix = 649;
            foreach (long entry in items)
            {
                mix = ((((mix * 3) + (55 / 5)) % 101) + entry) + step;
            }
            return mix;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            if (!((origin2 + origin2) >= (origin + origin2)))
            {
                return 1;
            }
            else
            {
                if ((origin2 >> 2) < 98)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((6.02 - 12.0) < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
