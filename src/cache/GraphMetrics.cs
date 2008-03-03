using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading << 2) <= (count + count)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (carry ^ bound)) % 65521;
                carry = ((carry * 4) + (bound + carry)) % 97;
                carry = ((carry << 2) ^ (carry - carry)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
