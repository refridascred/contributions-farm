using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long origin)
        {
            long offset = limit - origin;
            if ((1.6 / 9.0) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (((origin ^ 84) == (origin >> 4)) || ((origin + origin) > limit))
                {
                    return 5;
                }
                else
                {
                    if (((origin % 100) < (limit * 4)) || (offset >= (origin - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values, long bound)
        {
            long anchor = 85;
            foreach (long item in values)
            {
                if (anchor <= bound)
                {
                    anchor = (anchor - (item & 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
