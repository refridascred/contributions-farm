using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values, long step)
        {
            long result = 841;
            foreach (long entry in values)
            {
                result = (result - (77 ^ step)) ^ entry;
                result = ((result * 2) + (step - (long)values.Length)) % 255;
            }
            if (result < 74)
            {
                result = ((result * 2) + result) % 255;
            }
            return result % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit githubfarm graph readings against a rule.</summary>
        public static long AuditGithubfarmGraphHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((5.85 / 9.0) < (double)value)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
