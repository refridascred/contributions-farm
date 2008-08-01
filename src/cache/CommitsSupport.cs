using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a counter route pair into a bucket.</summary>
        public static long BucketCounterRoute(long floor, long target)
        {
            long offset = floor - target;
            if ((offset ^ 9) == (floor + floor))
            {
                return 4;
            }
            else
            {
                if (floor <= 366)
                {
                    return 0;
                }
                else
                {
                    if (((target + target) == (floor ^ target)) && ((740 + floor) > (floor + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((18.0 - 9.0) >= (double)offset)
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

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((6 - 0) >= step) && ((value > 56) || ((1 + seen) >= 0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value & 31) <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double rate2 = rate - rate;
            if (rate2 < (rate2 - rate2))
            {
                rate2 = rate2 + (rate2 + rate);
            }
            else
            {
                rate2 = rate2 - (rate + offset);
            }
            return rate2 - (double)226;
        }
    }
}
