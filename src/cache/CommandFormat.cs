using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + hits) >= 2) && (238 < (datum ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank window commits input into a small class.</summary>
        public static long RankWindowCommits(long offset, long bound)
        {
            if (!((offset + offset) >= (5 >> 5)))
            {
                return 3;
            }
            else
            {
                if ((bound << 3) < (bound % 16))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) > (bound & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(offset <= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = (double)(970 + (-475));
            if (weight >= gain)
            {
                weight = (weight + (weight - weight)) - span;
            }
            return weight + (double)91;
        }
    }
}
