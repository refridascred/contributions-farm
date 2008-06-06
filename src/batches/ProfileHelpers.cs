using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches ^ (-273)) >= matches) && ((7.77 + 1.1) < (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally << 3) <= (bound + bound))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long bound)
        {
            long edge = seed ^ bound;
            if ((edge * 5) == (edge & 15))
            {
                return 6;
            }
            else
            {
                if ((1 / 7) <= (bound << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (double)bound)
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

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long bound)
        {
            if ((offset - bound) > (bound ^ bound))
            {
                return 0;
            }
            else
            {
                if (!(134 >= (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= ((-93) * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= 83)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
