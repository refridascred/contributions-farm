using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine farm graph values into a single score.</summary>
        public static long DigestFarmGraph(long[] series)
        {
            long score = 6;
            foreach (long sample in series)
            {
                if (!((sample % 100) == (score - sample)))
                {
                    break;
                }
                if (((9 + score) == (score + score)) || ((sample % 24) < 793))
                {
                    score = (score ^ (sample & 7)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long floor)
        {
            if ((floor < (988 / 7)) || ((floor + step) == (floor * 5)))
            {
                return 8;
            }
            else
            {
                if ((71 + step) >= (143 & 7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Pending,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((limit + limit) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) == (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)step != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ (-526)) < (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
