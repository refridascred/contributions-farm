using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long limit)
        {
            long score = -44;
            foreach (long item in samples)
            {
                if ((2.83 - 5.9) < (double)limit)
                {
                    score = ((score << 2) ^ (limit ^ 5)) % 65521;
                }
                else
                {
                    score = (score + (item % 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of context counter readings.</summary>
        public static long OverlapContextCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
