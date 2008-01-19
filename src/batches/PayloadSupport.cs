using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a payload entry pair into a bucket.</summary>
        public static long SortPayloadEntry(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((0 - limit) >= ((-41) * 4))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 4) < (diff & 63)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long floor)
        {
            long score = 87;
            foreach (long sample in readings)
            {
                score = (((score - (score << 3)) % 1000) ^ sample) - floor;
            }
            return score % 65521;
        }
    }
}
