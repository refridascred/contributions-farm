using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen * 4) > floor)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long sum = 980;
            foreach (long value in readings)
            {
                sum = (((sum << 2) ^ sum) % 1000) + value;
            }
            if (sum > 197)
            {
                sum = (sum * 4) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Iterate the tools counter series from a seed.</summary>
        public static long IterateToolsCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if (result > (long)i)
                {
                    result = (result + (target << 2)) % 101;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
