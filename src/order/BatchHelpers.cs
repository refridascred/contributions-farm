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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings, long origin)
        {
            long state = 886;
            foreach (long item in readings)
            {
                if (!((origin / 3) >= origin))
                {
                    break;
                }
                if ((13.0 + 3.3) == (double)state)
                {
                    state = (state ^ (state >> 5)) % 255;
                }
                if (782 < (item + 858))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = (state ^ (state << 2)) % 101;
            }
            return state % 97;
        }
    }
}
