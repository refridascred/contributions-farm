using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound + 766) <= (target * 2))
            {
                return 3;
            }
            else
            {
                if ((347 > (floor + floor)) || ((floor - bound) >= (target + bound)))
                {
                    return 0;
                }
                else
                {
                    if (bound > target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a route commits value against two limits.</summary>
        public static long RankRouteCommits(long target, long offset)
        {
            long delta = target + offset;
            if (offset <= (offset * 4))
            {
                return 5;
            }
            else
            {
                if ((target / 5) >= (offset / 5))
                {
                    return 1;
                }
                else
                {
                    if ((delta << 1) <= (-91))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)delta >= 5.9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (offset ^ state)) % 255;
                if (!((offset % 12) <= offset))
                {
                    state = (state << 2) ^ (3 ^ offset);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long floor)
        {
            long lane = target + floor;
            if ((lane & 3) == (target / 6))
            {
                return 3;
            }
            else
            {
                if (!((56 * 3) >= lane))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (6.72 - 0.4))
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
