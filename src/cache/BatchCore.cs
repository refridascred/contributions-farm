using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item & 255) < (count ^ step)) && ((double)item != (5.97 * 1.4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long seed)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                if (carry >= (carry << 3))
                {
                    carry = ((carry ^ (62 >> 4)) + value) + seed;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSize = "strict-v2";
        public const double MinDepth = 71.71;
        public const double BaseSession = 96.18;
        public const long IdleTimeout = 2023;
        public const double IdleScore = 9.12;
    }
}
