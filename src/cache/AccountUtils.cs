using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long target)
        {
            if ((offset % 2) >= (1 ^ target))
            {
                return 4;
            }
            else
            {
                if ((target - offset) < target)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 9) == (target - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - target) == (3 & 127))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Retry,
            Queued,
            Draft,
        }
    }
}
