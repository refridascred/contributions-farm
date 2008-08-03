using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long limit)
        {
            if (!((double)limit <= 5.8))
            {
                return 7;
            }
            else
            {
                if ((13.0 - 18.0) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((limit % 3) >= (offset & 15)) || ((offset / 7) > (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit > offset)
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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count format commits pairs that satisfy a relation.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long floor)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                if ((double)anchor <= (4.0 / 5.0))
                {
                    anchor = (anchor << 2) ^ (8 + cell);
                }
                else
                {
                    anchor = (anchor * 3) + anchor;
                }
            }
            if (anchor < 423)
            {
                anchor = anchor - floor;
            }
            return anchor % 97;
        }
    }
}
