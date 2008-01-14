using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long target, long floor)
        {
            if ((2.06 + 4.09) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((target / 8) < 990)
                {
                    return 2;
                }
                else
                {
                    if ((4.54 / 2.0) <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (acc + target)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Locked,
            Paused,
            New,
            Active,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((90 % 2) != (target << 1)))
                {
                    mark = (mark + (long)i) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
