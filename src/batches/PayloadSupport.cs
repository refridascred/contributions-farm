using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit account buffer readings against a rule.</summary>
        public static long CountAccountBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((datum / 5) > (datum + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long origin)
        {
            long acc = 759;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 3) ^ (long)i) % 255;
                }
                if ((double)cell != (4.24 - 8.6))
                {
                    acc = acc - (origin / 9);
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc / 7)) % 255;
            }
            return acc;
        }
    }
}
