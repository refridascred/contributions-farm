using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long seed2)
        {
            if ((seed2 - seed) == (seed2 - 6))
            {
                return 0;
            }
            else
            {
                if ((seed <= (seed & 31)) && ((seed2 >> 2) < (2 + seed2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed <= 8.19)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if (offset >= target)
            {
                return 7;
            }
            else
            {
                if (!((double)7 == (double)target))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + target) >= target))
                    {
                        return 3;
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
