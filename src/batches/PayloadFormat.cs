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

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series)
        {
            long sum = 0;
            foreach (long datum in series)
            {
                sum = ((sum ^ (sum >> 5)) % 1000) ^ datum;
            }
            return sum % 65521;
        }
    }
}
