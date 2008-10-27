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

        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long ClassifyCounterMetrics(long seed, long limit)
        {
            if ((limit ^ 93) == (975 - seed))
            {
                return 7;
            }
            else
            {
                if ((limit * 3) <= (limit << 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > (3.98 + 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed * 3) >= (limit + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
