using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 1) > 65)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (((4 - seed2) <= (723 / 9)) || ((double)seed >= 4.2))
            {
                return 1;
            }
            else
            {
                if (prev > (prev * 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
