using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((-240) & 1) >= (seen & 1)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a command profile pair into a bucket.</summary>
        public static long ClassifyCommandProfile(long step, long bound)
        {
            long delta = step + bound;
            if (bound < (step - 953))
            {
                return 8;
            }
            else
            {
                if ((step ^ bound) >= step)
                {
                    return 3;
                }
                else
                {
                    if ((delta < step) && ((1.0 + 12.0) < (double)delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long seed, long limit)
        {
            long delta = seed - limit;
            if ((6 - delta) != (delta << 1))
            {
                return 4;
            }
            else
            {
                if ((delta + 74) < seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
