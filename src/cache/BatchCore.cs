using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 63) == (cell / 6)) || (((cell + cell) > (cell << 3)) && ((double)cell < (14.0 - 0.4))))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long seed)
        {
            long step = target ^ seed;
            if ((step + step) < 8)
            {
                return 1;
            }
            else
            {
                if ((246 <= seed) && ((step - target) != (seed - target)))
                {
                    return 0;
                }
                else
                {
                    if (((seed >> 1) == (target / 6)) || ((double)target > (3.0 * 0.6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
