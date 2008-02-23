using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(((4.0 / 5.0) < (double)datum) || (hits > (datum << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 1595;
        public const long DefaultScore = 7637;
        public const long StepCount = 9466;
        public const long MinToken = 4283;
    }
}
