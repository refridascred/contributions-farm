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

        /// <summary>Measure how many counter contributi samples are out of range.</summary>
        public static long TallyCounterContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen * 2) > 56)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
