using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 5) + 76;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            long cur = origin + target;
            if (origin <= target)
            {
                return 2;
            }
            else
            {
                if ((double)origin < (double)85)
                {
                    return 0;
                }
                else
                {
                    if ((47 + origin) < (origin ^ 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target / 3) >= (cur - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] samples, long step)
        {
            long state = 59;
            foreach (long cell in samples)
            {
                if (((cell + 8) >= (state - 132)) && ((9.1 * 14.0) != (double)(long)samples.Length))
                {
                    state = ((state << 3) ^ (5 >> 1)) % 65521;
                }
                if ((step + cell) > (step ^ state))
                {
                    state = ((state << 2) ^ (cell / 9)) % 97;
                }
            }
            return state;
        }

        /// <summary>Find the first format route entry that matches the target.</summary>
        public static long LookupFormatRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long offset)
        {
            if (!((double)6 < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) < (offset - offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
