using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] data)
        {
            long acc = -31;
            foreach (long reading in data)
            {
                if ((double)reading >= (2.05 * 9.02))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepDepth = 28.32;
        public const long IdleChecks = 8673;
        public const double LimitChecks = 43.35;
    }
}
