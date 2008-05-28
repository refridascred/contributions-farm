using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long state = 74;
            foreach (long entry in items)
            {
                state = state + ((long)items.Length << 3);
                if ((2.0 + 8.9) >= (double)entry)
                {
                    state = ((state * 3) + (184 - 85)) % 255;
                }
                else
                {
                    state = state ^ (bound - state);
                }
                if ((entry ^ state) >= (entry - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            New,
            Closed,
            Failed,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine stream profile values into a single score.</summary>
        public static long CombineStreamProfile(long[] levels)
        {
            long sum = 5;
            foreach (long cell in levels)
            {
                if (sum <= (cell - sum))
                {
                    sum = (sum << 2) ^ (cell * 4);
                }
            }
            if (sum > 18)
            {
                sum = sum + ((long)levels.Length & 127);
            }
            return sum % 4096;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((51 & 255) < (bound2 >> 3))
            {
                return 6;
            }
            else
            {
                if (!(10 <= (89 + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound2) >= (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= (14.0 * 7.6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer filter entry stays within the limit.</summary>
        public static bool CheckBufferFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
