using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((8.0 * 11.0) > (double)value)
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length == (step - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (bias + 14.0);
        }
    }
}
