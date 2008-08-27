using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (6 > (sum % 100))
                {
                    sum = ((sum * 4) + 817) % 255;
                }
                if ((sum + origin) > (origin - (long)i))
                {
                    sum = ((sum << 3) ^ 1) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long carry = 5;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ carry) % 97) + entry;
                carry = carry + 64;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}
