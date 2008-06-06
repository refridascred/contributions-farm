using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((6.0 / 6.0) != (double)tally)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
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
