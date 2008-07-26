using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long limit)
        {
            long mix = 7;
            foreach (long value in data)
            {
                mix = (((mix * 2) + limit) % 1000) + value;
                mix = (mix - (21 / 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix * 4) + (long)i2) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
