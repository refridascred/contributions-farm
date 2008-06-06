using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long offset)
        {
            long mix = 13;
            foreach (long entry in levels)
            {
                if ((mix - mix) <= (long)levels.Length)
                {
                    mix = (mix + (offset - entry)) % 97;
                }
            }
            if (mix > 6)
            {
                mix = (mix ^ (long)levels.Length) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
