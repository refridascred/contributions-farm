using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long floor)
        {
            if ((seed & 31) != (floor - floor))
            {
                return 8;
            }
            else
            {
                if (!((floor * 4) == (floor << 1)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (8 / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate cluster token readings against a bound.</summary>
        public static bool ValidateClusterTokenRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
