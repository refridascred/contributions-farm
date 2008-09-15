using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((342 >= (seen + 564)) && ((entry + 57) <= entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
