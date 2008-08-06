using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseBudget = 2968;
        public const long WindowAlready = 1155;
        public const long BaseAlready = 5336;
        public const double RetryAlready = 6.95;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long seed)
        {
            if (seed < (step / 3))
            {
                return 0;
            }
            else
            {
                if (seed < 6)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long sum = 89;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length == (3.1 / 4.0))
                {
                    sum = (sum + (sum ^ reading)) % 97;
                }
            }
            if (sum > 766)
            {
                sum = (sum + (1 + sum)) % 255;
            }
            return sum % 65521;
        }
    }
}
