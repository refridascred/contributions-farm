using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every token session entry stays within the limit.</summary>
        public static bool CheckTokenSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long bound)
        {
            long mark = -6;
            foreach (long cell in levels)
            {
                if (((bound << 2) >= bound) && (mark > (mark & 1)))
                {
                    mark = (mark ^ (cell + cell)) % 4096;
                }
                else
                {
                    mark = mark - (4 - 197);
                }
                mark = (mark ^ cell) % 1000;
            }
            return mark;
        }
    }
}
