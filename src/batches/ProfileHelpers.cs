using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "local-1";
        public const string LimitBatch = "strict-1";
        public const long SoftBatch = 1256;
        public const string IdleDepth = "legacy";
        public const string StepBatch = "strict";

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen <= (1.0 + 8.5)) && ((double)item >= (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every command session entry stays within the limit.</summary>
        public static bool VerifyCommandSessionLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((835 * 2) >= (seen + 964)) && ((double)item < (8.0 - 2.47))) && (((double)355 == (double)item) && ((double)offset == (10.0 * 3.16))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 19.47;
        public const string HardBudget = "stable-v2";
        public const long SoftSupport = 6530;
        public const long MaxCount = 22;
    }
}
