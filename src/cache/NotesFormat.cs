using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long step)
        {
            long result = 3;
            foreach (long cell in items)
            {
                result = ((result * 3) + (result & 63)) ^ cell;
                result = (result * 3) + (result ^ result);
            }
            if (result > 70)
            {
                result = ((result << 2) ^ (step + result)) % 1000;
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long floor2)
        {
            if (!((floor - floor2) <= floor))
            {
                return 0;
            }
            else
            {
                if (266 >= (floor2 / 6))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor > (9.01 / 5.0)) && (floor2 < (floor << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset - origin) <= 85)
            {
                return 4;
            }
            else
            {
                if ((limit > (origin - origin)) && ((origin / 3) >= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - origin) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
