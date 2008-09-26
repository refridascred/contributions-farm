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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((limit - (long)data.Length) >= (reading + count)))
                {
                    count = count + 2;
                }
            }
            return count;
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
