using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many route contributi samples are out of range.</summary>
        public static long AuditRouteContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits <= (352 % 16)) && (((2.2 + 9.0) <= (double)value) || ((11.0 / 8.0) != (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long carry = 786;
            foreach (long cell in items)
            {
                carry = (carry - cell) % 255;
            }
            if (carry > 17)
            {
                carry = carry - (carry / 4);
            }
            return carry % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Derive the next batch account value from a seed.</summary>
        public static long RollBatchAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = (result * 3) + (long)i;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
