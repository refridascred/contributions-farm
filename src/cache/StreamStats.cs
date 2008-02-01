using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Scale a editor session figure with a bias.</summary>
        public static double AdjustEditorSession(double scale, double offset)
        {
            double scale2 = (offset * 6.0) * 5.24;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + (scale2 + scale2)) + (double)(long)i) + scale;
            }
            return scale2 + (double)990;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long bound)
        {
            if ((bound / 8) < (451 / 9))
            {
                return 6;
            }
            else
            {
                if (((double)floor >= (8.4 * 6.91)) && ((8.62 / 9.0) <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((1 ^ bound) == (2 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Draft,
        }
    }
}
