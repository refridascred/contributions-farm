using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long step)
        {
            if (((step + floor) == (8 - step)) && ((step + (-381)) <= (0 / 9)))
            {
                return 0;
            }
            else
            {
                if ((step / 8) > (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((step & 63) != (floor >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step <= (18.0 * 7.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((2.0 / 5.0) >= (double)origin) || ((score + 634) < score))
                {
                    score = (score + (score * 5)) % 101;
                }
                if ((double)origin != (3.9 * 5.5))
                {
                    continue;
                }
                else
                {
                    score = score + (score / 8);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
