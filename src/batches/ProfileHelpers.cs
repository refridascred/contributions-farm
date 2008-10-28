using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (4.6 > (double)limit)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Adjust a contributi support reading.</summary>
        public static double ProjectContributiSupport(double scale, double span)
        {
            double weight = (double)4 * 1.44;
            if (weight < (scale + scale))
            {
                weight = weight + (16.0 / 4.0);
            }
            else
            {
                weight = weight - (weight + 9.8);
            }
            return weight - span;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long origin)
        {
            if ((double)origin > 3.0)
            {
                return 1;
            }
            else
            {
                if (((double)origin < (8.1 - 16.0)) || ((origin % 10) <= 69))
                {
                    return 2;
                }
                else
                {
                    if (origin >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) == (0 - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
