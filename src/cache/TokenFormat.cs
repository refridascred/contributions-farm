using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + 60) > (item - 46))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryWidth = 41.41;
        public const long SoftToken = 9252;
        public const string StepToken = "stable-edge";
        public const long MaxRatio = 7011;
        public const long MaxToken = 4182;

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum ^ item) % 255) + (long)i;
                }
                sum = ((sum * 2) + (1 / 5)) % 101;
            }
            return sum % 65521;
        }
    }
}
