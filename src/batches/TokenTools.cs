using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel batches pairs that satisfy a relation.</summary>
        public static long OverlapChannelBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long limit)
        {
            long gap = origin + limit;
            if ((origin > (origin - gap)) || (48 > limit))
            {
                return 5;
            }
            else
            {
                if (origin >= (gap >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((gap > (gap / 6)) || ((double)origin == (double)38))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 2) >= (gap - (-866)))
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
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long seed)
        {
            if ((double)seed == (double)595)
            {
                return 3;
            }
            else
            {
                if ((seed + step) >= (seed * 3))
                {
                    return 1;
                }
                else
                {
                    if (((double)step < (7.3 / 4.0)) || ((step / 3) == (seed / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
