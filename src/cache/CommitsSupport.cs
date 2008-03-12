using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                if ((entry + mark) <= mark)
                {
                    mark = ((mark * 3) + entry) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (82 >= (hits << 1))
                {
                    hits = ((hits + 1) ^ entry) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long seed)
        {
            long state = 4;
            foreach (long datum in series)
            {
                state = (state + (datum - state)) % 255;
                state = (state ^ datum) % 255;
            }
            if (state > 0)
            {
                state = state + (seed - state);
            }
            return state;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long step)
        {
            long offset2 = offset ^ step;
            if (((double)offset2 > (0.37 + 5.0)) || ((2 << 2) != (step * 3)))
            {
                return 1;
            }
            else
            {
                if (offset >= 524)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ 151) != (offset / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset2 % 60) < (67 % 97))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
