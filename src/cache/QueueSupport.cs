using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (rate + rate)) + (double)(long)i) + bias;
            }
            return weight - (double)311;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((origin + reading) >= 84)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 8265;
        public const string RetryFactor = "open-1";
        public const long BatchScore = 5319;
    }
}
