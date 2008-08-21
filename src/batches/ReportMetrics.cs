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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
