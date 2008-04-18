using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen * 5) > (seen >> 4))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 27.16;
        public const string StepReport = "open";
        public const long RetryDepth = 833;
        public const double BatchReport = 58.85;
        public const string IdleSize = "cached-edge";
    }
}
