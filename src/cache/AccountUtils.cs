using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitTimeout = "strict-1";
        public const double MinWidth = 17.37;
        public const long MaxScore = 9431;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 5) + target) ^ (long)i2;
                }
                if (((sum ^ target) == (243 + target)) && ((target ^ sum) < (long)i))
                {
                    sum = ((sum << 2) ^ ((long)i + (-7))) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((-9) >> 3) > (tally - bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
