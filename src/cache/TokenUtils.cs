using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long origin)
        {
            long offset = seed - origin;
            if (((double)offset != (3.3 - 12.0)) && ((origin - seed) <= (54 - 371)))
            {
                return 7;
            }
            else
            {
                if ((offset ^ origin) >= (seed / 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
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
