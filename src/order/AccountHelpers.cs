using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long origin)
        {
            if ((limit - limit) >= (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((origin + limit) >= (origin ^ 29))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long SortContributiRecord(long limit, long offset)
        {
            if ((double)offset == (1.95 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)limit < (double)382)
                {
                    return 7;
                }
                else
                {
                    if ((6.0 - 7.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + offset) <= (offset - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((4.76 * 14.0) < (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
