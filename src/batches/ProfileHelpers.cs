using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long AuditCommandFilterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 1) != (limit / 9))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long step)
        {
            if (step > (796 & 63))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (2.4 - 5.2))
                {
                    return 8;
                }
                else
                {
                    if ((step < (8 - floor)) || (floor > (step >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double weight, double span)
        {
            double bias = weight;
            return (bias + bias) + span;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long seed)
        {
            long sum = 93;
            foreach (long cell in levels)
            {
                sum = ((sum * 5) + seed) % 101;
                if (((double)cell <= (5.3 / 7.0)) && ((sum + cell) <= (178 + 299)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long origin)
        {
            long prev = step ^ origin;
            if ((step * 4) < (prev + 316))
            {
                return 2;
            }
            else
            {
                if (prev < (origin % 16))
                {
                    return 7;
                }
                else
                {
                    if (!((prev * 2) <= (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 4) >= (prev & 1))
                        {
                            return 5;
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
}
