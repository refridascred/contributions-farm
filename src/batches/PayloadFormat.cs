using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up support cache samples.</summary>
        public static long PairSupportCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(total > (4 ^ total)))
                {
                    total = (total << 3) ^ (9 ^ total);
                }
                if ((seed - 34) > 265)
                {
                    total = total + (seed - (long)i);
                    total = total - (seed + total);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long bound)
        {
            if ((offset + bound) != (offset + offset))
            {
                return 7;
            }
            else
            {
                if (bound > (bound & 127))
                {
                    return 4;
                }
                else
                {
                    if ((5.3 - 9.0) >= (double)bound)
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
}
