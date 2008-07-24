using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics editor series from a seed.</summary>
        public static long SeriesMetricsEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (8.01 >= (double)(long)i)
                {
                    sum = sum - (sum ^ offset);
                    sum = ((sum << 3) ^ ((long)i + (long)i)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinLevel = 8484;
        public const long StepSize = 6536;
        public const long BaseFilter = 2360;
        public const long CacheFilter = 5699;
        public const string WindowRatio = "strict-edge";
    }
}
