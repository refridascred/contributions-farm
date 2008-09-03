using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long value in samples)
            {
                acc = acc - (acc + value);
                if (origin >= (acc * 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -756;
            foreach (long sample in values)
            {
                mark = (mark * 2) + (sample & 7);
            }
            return mark % 65521;
        }

        /// <summary>Roll a context notes counter forward.</summary>
        public static long StepContextNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
