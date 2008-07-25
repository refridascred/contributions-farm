using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue graph series from a seed.</summary>
        public static long DeriveQueueGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + 7) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (18.0 > (double)mark)
                {
                    mark = ((mark * 5) + (415 ^ mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Idle,
            Draft,
            Active,
            New,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 5) > (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
