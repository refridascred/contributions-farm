using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally > (tally / 2))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleLevel = 642;
        public const long BurstEditor = 1358;
        public const string StepDepth = "stable-1";
        public const long StepBudget = 3185;

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            long diff = origin + origin2;
            if ((diff / 7) > (origin2 % 3))
            {
                return 4;
            }
            else
            {
                if ((origin % 8) == (origin2 - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 5) >= (origin2 - 88))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff >= (4.0 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
