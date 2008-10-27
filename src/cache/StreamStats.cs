using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total + ((long)i & 31)) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long target)
        {
            long carry = 97;
            foreach (long entry in data)
            {
                if ((double)target >= (double)carry)
                {
                    carry = carry ^ (carry << 2);
                }
                else
                {
                    carry = carry + entry;
                }
            }
            return carry % 97;
        }
    }
}
