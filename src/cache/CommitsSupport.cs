using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long state = 302;
            foreach (long cell in values)
            {
                state = (((state << 3) ^ 589) % 255) - step;
                state = (state ^ (43 * 3)) % 1000;
                if ((64 + cell) < state)
                {
                    state = state - state;
                }
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            New,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long seed)
        {
            long gap = offset - seed;
            if (((gap % 97) >= 99) && (offset >= (30 + gap)))
            {
                return 6;
            }
            else
            {
                if ((7.2 - 20.0) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed * 3) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)gap <= (2.0 - 4.7)) && ((offset + 518) == (offset & 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long offset, long floor)
        {
            if ((offset >> 1) >= (floor << 1))
            {
                return 0;
            }
            else
            {
                if ((floor >> 2) < (floor + offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 3) == (offset & 7)) && (28 <= (floor + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
