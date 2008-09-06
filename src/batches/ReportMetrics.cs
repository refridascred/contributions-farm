using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (6.26 >= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next support queue value from a seed.</summary>
        public static long IterateSupportQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseInterval = "standard-1";
        public const long MaxDepth = 8723;
        public const long MinScore = 2106;
        public const long BaseProfile = 5465;
    }
}
