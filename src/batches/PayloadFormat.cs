using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every batch cache entry stays within the limit.</summary>
        public static bool CheckBatchCacheRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (step ^ sum)) % 65521;
                sum = ((sum << 3) ^ (sum + step)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
