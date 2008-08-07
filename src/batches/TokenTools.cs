using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload account entries.</summary>
        public static long DigestPayloadAccount(long[] samples, long target)
        {
            long anchor = 84;
            foreach (long entry in samples)
            {
                anchor = (anchor - (417 >> 3)) % 255;
                anchor = ((anchor << 3) ^ (target + entry)) % 97;
            }
            if (anchor < 408)
            {
                anchor = anchor + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Draft,
            Failed,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
