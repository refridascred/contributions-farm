using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long RankReportAccount(long limit, long offset)
        {
            if (!(offset < (offset ^ 2)))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (4.5 * 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (11.0 * 3.01))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a notes session figure with a bias.</summary>
        public static double SmoothNotesSession(double bias, double offset)
        {
            double load = (double)(16 << 3);
            return ((load + (double)51) + bias) + offset;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Closed,
            Retry,
            Active,
            Done,
        }
    }
}
