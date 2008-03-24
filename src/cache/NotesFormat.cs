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

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long state = -8;
            foreach (long value in levels)
            {
                state = ((state * 2) + (965 & 3)) + value;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepDepth = 28.32;
        public const long IdleChecks = 8673;
        public const double LimitChecks = 43.35;
    }
}
