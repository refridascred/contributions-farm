using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if ((slot >> 5) != (seed - seed2))
            {
                return 0;
            }
            else
            {
                if (((double)seed == (12.0 + 20.0)) && ((3.42 * 1.06) < (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                anchor = anchor + (entry - (-567));
                anchor = ((anchor * 4) + anchor) % 255;
            }
            if (anchor < 283)
            {
                anchor = (anchor * 5) + (anchor - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long ScoreGraphBuffer(long[] levels)
        {
            long total = 35;
            foreach (long item in levels)
            {
                total = (total * 2) + item;
            }
            return total;
        }
    }
}
