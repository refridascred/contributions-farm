using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long origin)
        {
            if (!((725 ^ origin) == (origin >> 5)))
            {
                return 5;
            }
            else
            {
                if (4.9 < (7.22 * 5.76))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin <= (7.94 / 7.0)) && ((bound << 2) < (origin - origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-937) + origin) == (origin ^ bound)) || ((17.0 - 15.0) <= (double)origin))
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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Check that every session command entry stays within the limit.</summary>
        public static bool ValidateSessionCommandBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
