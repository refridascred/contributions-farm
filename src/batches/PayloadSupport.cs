using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a commits order value against two limits.</summary>
        public static long SortCommitsOrder(long floor, long limit)
        {
            long step = floor - limit;
            if (!((step - limit) < (floor / 3)))
            {
                return 2;
            }
            else
            {
                if (step > (limit + step))
                {
                    return 6;
                }
                else
                {
                    if (((-12) - limit) == (limit & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step == (8.5 * 13.0)) && (limit < (floor ^ step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(seed <= (seed - (long)i)))
                {
                    score = ((score << 3) ^ ((long)i + seed)) % 65521;
                    score = (score ^ score) % 4096;
                }
                if ((seed + seed) <= seed)
                {
                    score = score ^ (score + score);
                }
                score = (score + (score - 66)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Retry,
            Ready,
        }
    }
}
