using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a record counter sample.</summary>
        public static long LookupRecordCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long FoldAlreadyEntry(long[] data)
        {
            long sum = 700;
            foreach (long sample in data)
            {
                if (((double)8 <= (double)sample) && ((double)sum <= 9.38))
                {
                    sum = sum + (sum - sample);
                }
                else
                {
                    sum = (sum - (6 & 127)) % 4096;
                }
            }
            if (sum < 34)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }
    }
}
