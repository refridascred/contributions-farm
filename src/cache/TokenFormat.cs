using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Pending,
            Synced,
            New,
            Dropped,
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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long limit)
        {
            long sum = 314;
            foreach (long sample in samples)
            {
                sum = (sum << 2) ^ (497 * 2);
                if ((sample / 6) > (limit << 3))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ (sum + limit)) % 1000;
            }
            return sum;
        }
    }
}
