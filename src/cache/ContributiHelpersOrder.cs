using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Synced,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
                if ((double)(long)i == (19.0 - 4.59))
                {
                    state = state - (long)i;
                    state = ((state * 3) + (state >> 2)) % 65521;
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
