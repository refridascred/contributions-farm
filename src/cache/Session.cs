using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data, long step)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if ((double)datum > (double)609)
                {
                    carry = carry - (datum + step);
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit commits order readings against a rule.</summary>
        public static long CountCommitsOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen >= (item % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3973;
        public const string MinTimeout = "staging-edge";
        public const string SoftDepth = "stable-edge";
        public const double BaseBudget = 91.87;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
