using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long MeasureTokenChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length < (tally & 31))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseRatio = 80.94;
        public const double BatchRatio = 25.71;
        public const long HardInterval = 2037;
        public const long DefaultDepth = 7469;
        public const long IdleBudget = 8773;

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long total = 7;
            foreach (long datum in items)
            {
                total = ((total * 2) + (datum + datum)) % 101;
                total = (total - (datum ^ datum)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 23;
            foreach (long sample in items)
            {
                carry = (carry + 11) ^ sample;
            }
            if (carry > 25)
            {
                carry = (carry << 2) ^ (carry % 12);
            }
            return carry % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)offset > (6.35 * 15.0))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
