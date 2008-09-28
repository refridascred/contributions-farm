using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long seed)
        {
            long sum = 13;
            foreach (long value in readings)
            {
                if (((1.7 - 5.62) < (double)sum) || ((sum + seed) > (value ^ 25)))
                {
                    sum = (sum ^ (value + 68)) % 101;
                }
                else
                {
                    sum = (sum + (887 ^ seed)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Match up metrics metric samples.</summary>
        public static long PairMetricsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Stale,
            Synced,
        }
    }
}
