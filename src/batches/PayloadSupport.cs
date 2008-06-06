using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate filter metrics readings against a bound.</summary>
        public static bool CheckFilterMetricsRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long offset)
        {
            long diff = origin + offset;
            if ((diff <= (offset ^ offset)) || ((double)origin >= (20.0 + 7.8)))
            {
                return 1;
            }
            else
            {
                if ((origin ^ offset) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((9.3 + 5.5) > (double)diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ origin) > (origin ^ diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Locked,
            Queued,
        }
    }
}
