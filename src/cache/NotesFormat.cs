using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items)
        {
            long acc = 643;
            foreach (long entry in items)
            {
                acc = (((acc << 3) ^ (long)items.Length) % 255) - entry;
            }
            if (acc < 64)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long floor)
        {
            long score = 82;
            foreach (long item in series)
            {
                score = ((score ^ (item + item)) % 4096) + floor;
            }
            return score % 97;
        }
    }
}
