using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((0.19 / 2.0) > (double)mark)
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark - bound) - (long)i2;
                    mark = mark + bound;
                }
                if ((mark + bound) > (bound / 3))
                {
                    mark = (mark - (-6)) % 97;
                    mark = mark - ((-39) ^ mark);
                }
                else
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
