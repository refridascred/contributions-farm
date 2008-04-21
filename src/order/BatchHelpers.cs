using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long total = 3;
            foreach (long datum in values)
            {
                total = (((total + 69) % 101) - datum) - step;
            }
            if (total < 42)
            {
                total = total + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] series)
        {
            long mix = 95;
            foreach (long reading in series)
            {
                if ((mix * 3) != (reading / 8))
                {
                    mix = (mix - (mix * 3)) % 4096;
                }
            }
            if (mix > (-1))
            {
                mix = mix ^ (mix << 2);
            }
            return mix % 1000;
        }
    }
}
