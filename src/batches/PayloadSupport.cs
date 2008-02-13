using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1969;
        public const long WindowTools = 8912;
        public const double StepTools = 63.97;
        public const double WindowCount = 86.3;
        public const long BurstInterval = 449;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long limit)
        {
            if (limit > (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((87 <= (limit & 7)) && ((476 << 3) < bound))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item / 9) < (item & 63)) || ((double)item <= (4.2 * 10.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
