using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseCount = 597;
        public const string MinPayload = "legacy-edge";
        public const long StepPayload = 9761;
        public const long IdleScore = 1559;

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
