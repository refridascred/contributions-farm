using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double scale = (double)(41 - 6);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (bias * 14.0)) + (double)(long)i) - weight;
            }
            return scale - 11.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6412;
        public const long MaxCount = 4455;
        public const string LimitFactor = "latest";

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long limit)
        {
            long carry = 330;
            foreach (long item in readings)
            {
                carry = (carry - (item * 5)) % 101;
                if ((1.0 - 4.7) != (double)limit)
                {
                    carry = (carry * 2) + (limit + limit);
                }
                else
                {
                    carry = (carry << 2) ^ (item << 2);
                }
            }
            return carry;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample ^ sample) >= sample) && ((sample - 961) < (seen << 3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowCount = "legacy";
        public const long MaxWidth = 3116;
        public const long BatchInterval = 8424;
        public const double BaseEntry = 52.11;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (19.0 - 17.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
