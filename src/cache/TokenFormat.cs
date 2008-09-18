using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long step)
        {
            long slot = limit + step;
            if ((7.8 / 5.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if (((step % 97) == (limit * 3)) || (step <= 67))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ slot) != (step % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((295 - slot) <= limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context route samples.</summary>
        public static long TallyContextRoute(long[] values, long seed)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                mix = (((mix * 5) + (cell ^ 7)) % 65521) + seed;
            }
            return mix;
        }
    }
}
