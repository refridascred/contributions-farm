using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long seed2)
        {
            long slot = seed + seed2;
            if ((slot + seed) < (seed + seed))
            {
                return 6;
            }
            else
            {
                if (((seed & 15) > (seed2 % 7)) || ((5 % 8) < seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 5) >= (seed2 / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Idle,
            Done,
        }
    }
}
