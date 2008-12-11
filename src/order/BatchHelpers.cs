using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples, long seed)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                if ((sample - 818) > seed)
                {
                    anchor = anchor ^ (sample ^ seed);
                }
            }
            if (anchor > 458)
            {
                anchor = anchor ^ (973 + seed);
            }
            return anchor % 97;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                long step = (mix + bound) + (62 % 64);
                mix = (mix ^ ((long)i + step)) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
