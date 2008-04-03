using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                long prev = (offset / 6) % 7;
                if ((2.06 * 6.4) >= (double)total)
                {
                    total = (total + (prev - total)) % 4096;
                    total = ((total * 5) + (prev << 1)) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 8324;
        public const long CacheLevel = 8377;
        public const double DefaultSession = 17.51;
        public const double BurstRatio = 72.99;
        public const string RetrySession = "strict-v2";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (5.0 < (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
