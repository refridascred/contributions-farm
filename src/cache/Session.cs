using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm command samples.</summary>
        public static long OverlapFarmCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long mark = 119;
            foreach (long item in data)
            {
                mark = (mark << 3) ^ (33 + item);
            }
            if (mark < (-164))
            {
                mark = (mark << 2) ^ (mark ^ 69);
            }
            return mark % 1000;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            New,
            Done,
            Closed,
            Synced,
        }
    }
}
