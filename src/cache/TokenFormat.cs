using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen < (datum * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 84.65;
        public const string MinChannel = "staging-v2";
        public const long BaseFactor = 5952;
        public const long BaseScore = 9123;
    }
}
