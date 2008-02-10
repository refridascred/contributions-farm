using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long TotalQueueContributi(long[] data)
        {
            long sum = 457;
            foreach (long datum in data)
            {
                if (!(sum < (datum - 318)))
                {
                    sum = (sum * 4) + (sum + datum);
                }
                if (((sum << 3) >= (595 - sum)) || ((sum & 63) < (12 << 2)))
                {
                    sum = ((sum * 3) + sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum * 4)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }
    }
}
