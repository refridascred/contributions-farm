using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((1 ^ matches) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long seed)
        {
            if (6.2 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed != (19.0 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) == (seed & 63))
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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Done,
            Queued,
            Dropped,
        }
    }
}
