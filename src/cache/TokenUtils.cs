using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long floor2)
        {
            if (229 <= floor)
            {
                return 8;
            }
            else
            {
                if ((floor2 * 2) == (floor2 & 63))
                {
                    return 7;
                }
                else
                {
                    if ((49 >> 4) > (floor2 >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally >= (double)datum) && (datum > (tally + 49))) && !((tally + tally) != (2 - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
