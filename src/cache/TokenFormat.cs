using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window queue entries.</summary>
        public static long TotalWindowQueue(long[] values)
        {
            long anchor = -87;
            foreach (long reading in values)
            {
                anchor = (anchor + reading) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a context token value against two limits.</summary>
        public static long SortContextToken(long step, long seed)
        {
            if ((step / 4) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed <= (9 - step)) && ((5 + step) < (step % 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) <= 58)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed / 7) > step)
                        {
                            return 7;
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
