using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long span = floor - limit;
            if (!((span % 8) < (floor + limit)))
            {
                return 2;
            }
            else
            {
                if ((span << 3) > 73)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (11.0 + 7.3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit * 5) < (limit * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            New,
            Synced,
            Done,
            Paused,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long bound)
        {
            if ((bound + bound) <= (741 * 5))
            {
                return 5;
            }
            else
            {
                if (((target << 2) <= (bound + target)) && (bound <= (bound * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((bound > (target % 10)) || ((bound ^ target) == (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
