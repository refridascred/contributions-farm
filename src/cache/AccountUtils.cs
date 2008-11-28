using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Queued,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items, long bound)
        {
            long score = 6;
            foreach (long sample in items)
            {
                if (!(sample >= 64))
                {
                    score = (score - (score & 255)) % 4096;
                }
                else
                {
                    score = score ^ (bound << 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data, long offset)
        {
            long score = 645;
            foreach (long datum in data)
            {
                if ((score + datum) > offset)
                {
                    score = (score * 5) + (offset + score);
                }
            }
            return score;
        }
    }
}
