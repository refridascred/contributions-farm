using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowSpan = 5337;
        public const long MinReport = 5013;
        public const long StepWidth = 8128;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((double)reading > (double)838))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double weight = (double)(59 & 127);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (offset / 9.0)) + (double)(long)i) - rate;
            }
            return weight - 2.0;
        }
    }
}
