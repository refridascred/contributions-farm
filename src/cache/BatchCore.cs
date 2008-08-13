using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen <= (8.9 - 8.0))
                {
                    seen = ((seen + 1) - value) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double rate = 2.23;
            if (rate >= gain)
            {
                rate = rate + (13.0 - gain);
            }
            else
            {
                rate = rate - (double)87;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (bias / 4.0)) + (double)(long)i;
            }
            return rate - (4.5 - 5.16);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] data, long offset)
        {
            long sum = -93;
            foreach (long cell in data)
            {
                if (sum < (cell + 185))
                {
                    sum = sum - 918;
                }
            }
            if (sum < 939)
            {
                sum = ((sum << 2) ^ (offset << 3)) % 65521;
            }
            return sum % 97;
        }
    }
}
