using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long target)
        {
            if ((offset <= target) || ((offset + target) <= 7))
            {
                return 6;
            }
            else
            {
                if (!(161 > (offset ^ target)))
                {
                    return 8;
                }
                else
                {
                    if (((offset >> 4) <= (target << 2)) || ((double)15 >= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + 26) == (target - offset)) || ((double)target >= (8.0 - 6.62)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double load = (rate / 3.0) + (13.0 * 4.0);
            if (load <= (double)421)
            {
                load = load + offset;
            }
            return load + rate;
        }
    }
}
