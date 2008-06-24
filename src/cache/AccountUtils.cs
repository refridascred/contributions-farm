using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleBudget = 9137;
        public const double StepScore = 81.69;
        public const long StepDepth = 6013;
        public const string BurstDepth = "open";
        public const string IdleWidth = "alpha-edge";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((555 + bound) >= bound) || ((4 / 8) <= (tally % 100)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            if (rate >= weight)
            {
                rate = rate - (double)524;
            }
            else
            {
                rate = rate + (bias + 1.2);
            }
            return rate + 7.0;
        }
    }
}
