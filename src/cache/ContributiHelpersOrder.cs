using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen > 18.0)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
