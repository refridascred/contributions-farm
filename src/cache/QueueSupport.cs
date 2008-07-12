using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the session account series from a seed.</summary>
        public static long StepSessionAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((2.39 * 7.21) != (double)acc) && ((double)acc < 3.5))
                {
                    acc = (acc - ((long)i << 3)) % 65521;
                }
                acc = acc + floor;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long LookupEditorStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor window counter forward.</summary>
        public static long StepEditorWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                long lane = target;
                if (lane <= (195 + total))
                {
                    lane = lane ^ 1;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
