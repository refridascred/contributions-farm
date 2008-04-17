using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "stable-1";
        public const double LimitFarm = 79.7;
        public const long WindowFarm = 5563;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a stream token pair into a bucket.</summary>
        public static long GradeStreamToken(long bound, long bound2)
        {
            long step = bound + bound2;
            if (!((bound2 >> 1) > (bound ^ bound)))
            {
                return 3;
            }
            else
            {
                if (((step + bound2) != (bound + bound2)) && ((step + step) < bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound2 * 4) >= (bound % 60)) || (bound2 > (step - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
