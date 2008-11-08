using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (cell / 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample + 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long step)
        {
            long slot = offset ^ step;
            if ((step << 1) != (step * 3))
            {
                return 4;
            }
            else
            {
                if (step >= (slot + offset))
                {
                    return 7;
                }
                else
                {
                    if ((4.28 / 7.0) != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot >> 4) <= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
