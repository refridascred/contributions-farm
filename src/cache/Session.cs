using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool VerifyCommitsFarmRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Draft,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Rank payload contributi input into a small class.</summary>
        public static long ClassifyPayloadContributi(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((double)origin2 >= (8.92 - 4.4))
            {
                return 2;
            }
            else
            {
                if ((cur % 10) < (cur % 16))
                {
                    return 5;
                }
                else
                {
                    if ((45 / 4) < (cur & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur + origin2) > cur)
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
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Synced,
            Failed,
            Ready,
        }
    }
}
