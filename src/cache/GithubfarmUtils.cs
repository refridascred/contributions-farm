using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine already profile values into a single score.</summary>
        public static long CombineAlreadyProfile(long[] readings, long step)
        {
            long anchor = 186;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ (anchor >> 5)) % 4096;
                if (!(((-93) + step) <= (step + step)))
                {
                    anchor = (anchor << 3) ^ step;
                }
                if ((double)step > (1.4 * 18.0))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long floor)
        {
            long state = 9;
            foreach (long value in levels)
            {
                if ((81 ^ floor) < (value << 1))
                {
                    state = state ^ (floor & 3);
                }
            }
            return state;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
