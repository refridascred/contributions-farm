using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 5824;
        public const double DefaultSession = 58.8;
        public const long BatchScore = 2349;
        public const long WindowSession = 1567;
        public const double BurstSize = 27.78;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long seed)
        {
            long gap = limit + seed;
            if ((34 - limit) >= (limit * 3))
            {
                return 8;
            }
            else
            {
                if (!((4.0 - 19.0) == (double)gap))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit != (9.21 - 17.0)) && ((seed - 47) > (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)gap == (0.08 - 8.26)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if ((span <= (span & 3)) && ((double)3 != (double)origin2))
            {
                return 6;
            }
            else
            {
                if ((origin2 + span) < origin2)
                {
                    return 7;
                }
                else
                {
                    if ((double)span < (1.0 * 6.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + 1;
                state = state - ((long)i & 63);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
