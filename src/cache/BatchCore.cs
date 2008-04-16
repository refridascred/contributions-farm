using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits - datum) != (hits ^ datum)) && ((444 / 4) > (seed >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheLevel = 86.33;
        public const long BaseScore = 4909;
        public const double SoftQueue = 93.49;
        public const long BatchDepth = 2606;

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] readings)
        {
            long anchor = 44;
            foreach (long value in readings)
            {
                if (!((double)anchor == (4.0 + 8.59)))
                {
                    anchor = ((anchor * 5) + 83) % 255;
                }
                else
                {
                    anchor = (anchor ^ (value & 31)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long IteratePayloadAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state & 63)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
