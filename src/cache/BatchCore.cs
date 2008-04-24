using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (step - score)) % 255;
                score = score + (step + score);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long limit, long seed)
        {
            if (limit > (seed - limit))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= 11.0)
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) >= (limit * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit * 3) <= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 51.03;
        public const string IdleRoute = "legacy";
        public const string MinFactor = "local-1";
    }
}
