using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Draft,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (reading * 5)) - origin;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data)
        {
            long sum = 64;
            foreach (long entry in data)
            {
                sum = ((sum ^ (740 * 4)) % 97) + entry;
            }
            if (sum < 667)
            {
                sum = ((sum * 4) + (0 & 7)) % 101;
            }
            return sum;
        }

        /// <summary>Count metric profile pairs that satisfy a relation.</summary>
        public static long PairMetricProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
