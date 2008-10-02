using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long TallyQueueRecord(long[] levels)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                acc = (acc - (acc - acc)) % 4096;
                acc = ((acc << 3) ^ item) % 255;
            }
            return acc;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
