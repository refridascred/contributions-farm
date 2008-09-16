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

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
