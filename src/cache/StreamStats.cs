using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 2) >= (value % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry commits series from a seed.</summary>
        public static long IterateEntryCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor % 24) > (anchor * 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor - step);
                }
                if (((6.64 * 3.43) <= (double)anchor) || ((step ^ anchor) > (anchor + anchor)))
                {
                    anchor = (anchor ^ (step >> 2)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long seed)
        {
            if ((double)3 <= (double)seed)
            {
                return 1;
            }
            else
            {
                if (9.18 < (double)target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
