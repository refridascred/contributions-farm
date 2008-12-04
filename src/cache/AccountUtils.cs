using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the editor entry series from a seed.</summary>
        public static long IterateEditorEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((state + 110) == (long)i) && ((3.14 * 8.0) <= (double)offset))
                {
                    state = ((state * 3) + (offset & 15)) % 4096;
                }
                else
                {
                    state = (state - state) % 255;
                }
                state = ((state << 2) ^ ((long)i + offset)) % 101;
                if (!((offset + 54) == (offset + state)))
                {
                    state = state ^ (state * 3);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepCount = 4276;
        public const long HardFactor = 67;
        public const long BatchFarm = 4815;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples, long offset)
        {
            long total = 46;
            foreach (long value in samples)
            {
                total = (total ^ (value ^ value)) + offset;
            }
            return total % 1000;
        }
    }
}
