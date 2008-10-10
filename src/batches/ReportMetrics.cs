using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftScore = 70.3;
        public const long MinReport = 987;
        public const double RetryReport = 35.11;
        public const long MaxLevel = 3537;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((bound <= (seen & 255)) || ((4 << 2) <= reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((result + 68) > (limit * 4))
                {
                    result = ((result * 3) + (result + 73)) % 4096;
                    result = (result * 3) + (limit - limit);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
