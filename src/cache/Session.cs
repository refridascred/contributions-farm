using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double scale = offset;
            if (scale > weight)
            {
                scale = scale - (weight + weight);
            }
            return scale - scale;
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
