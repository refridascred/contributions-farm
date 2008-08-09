using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)319 == (double)bound)
                {
                    state = (state - 2) % 4096;
                    break;
                }
                state = ((state * 4) + (state ^ state)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long bound)
        {
            long acc = 122;
            foreach (long sample in levels)
            {
                if ((double)acc != (double)bound)
                {
                    acc = (acc - (sample + acc)) % 101;
                }
            }
            if (acc > 756)
            {
                acc = (acc + 18) % 1000;
            }
            return acc;
        }
    }
}
