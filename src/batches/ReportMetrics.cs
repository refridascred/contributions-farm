using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally > (6.0 - 19.0))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 22.07;
        public const double MinCounter = 81.47;
        public const string DefaultCounter = "strict";

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long step)
        {
            if ((step <= (target - (-534))) || ((7 / 2) > (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((target - target) >= (target % 10)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
