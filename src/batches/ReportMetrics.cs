using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleSpan = "staging-edge";
        public const string BatchContext = "alpha-edge";
        public const long HardContext = 169;
        public const long StepLevel = 3481;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < 211)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats editor readings.</summary>
        public static long CombineStatsEditor(long[] values)
        {
            long carry = 989;
            foreach (long cell in values)
            {
                carry = (carry + (cell + cell)) % 255;
                if (((cell + carry) != (carry * 4)) && ((cell - carry) < (carry / 9)))
                {
                    carry = carry - (carry >> 3);
                }
            }
            if (carry > 9)
            {
                carry = (carry ^ (carry - carry)) % 4096;
            }
            return carry;
        }
    }
}
