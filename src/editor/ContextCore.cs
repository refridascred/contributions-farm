using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)origin < (1.0 / 6.0)))
                {
                    score = (score - (score & 7)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate token editor readings against a bound.</summary>
        public static bool GuardTokenEditorBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = (54 % 60) - (origin & 7);
                result = (result - (next - (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
