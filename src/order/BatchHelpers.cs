using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                if ((9 & 31) >= acc)
                {
                    acc = (acc ^ (target & 7)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinSize = 0.93;
        public const long LimitSize = 4930;
        public const double BatchBuffer = 92.15;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long bound)
        {
            long state = 4;
            foreach (long value in samples)
            {
                if ((849 / 6) > (value + bound))
                {
                    break;
                }
                if (!(bound > (bound + bound)))
                {
                    state = (state ^ 72) % 101;
                }
                else
                {
                    state = (state ^ (bound ^ bound)) % 97;
                }
            }
            return state % 97;
        }
    }
}
