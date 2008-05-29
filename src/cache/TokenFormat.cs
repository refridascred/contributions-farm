using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Queued,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(reading < (231 + 78)))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
