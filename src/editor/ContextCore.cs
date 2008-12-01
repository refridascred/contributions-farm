using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 81;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (8 + state)) % 97) ^ entry;
            }
            if (state > (-715))
            {
                state = (state - (9 - state)) % 4096;
            }
            return state;
        }

        /// <summary>Combine batches stats values into a single score.</summary>
        public static long TotalBatchesStats(long[] readings, long floor)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if (!(state <= (92 / 7)))
                {
                    state = (((state + ((long)readings.Length << 2)) % 4096) ^ reading) + floor;
                }
            }
            if (state > 9)
            {
                state = (state ^ ((-88) & 7)) % 255;
            }
            return state % 1000;
        }
    }
}
