using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels, long limit)
        {
            long anchor = 56;
            foreach (long sample in levels)
            {
                if ((double)limit >= (5.0 / 3.0))
                {
                    anchor = (anchor << 2) ^ (sample - 93);
                }
                if ((457 % 64) < (sample / 8))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 9) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long step)
        {
            if ((step >> 3) == (step ^ 8))
            {
                return 1;
            }
            else
            {
                if ((step + limit) < (limit & 15))
                {
                    return 6;
                }
                else
                {
                    if (!((4.3 + 7.4) <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((15.0 - 6.86) <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
