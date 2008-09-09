using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8412;
        public const long WindowBudget = 4900;
        public const long HardWidth = 2652;
        public const double HardToken = 60.02;

        /// <summary>Locate a support route reading by value.</summary>
        public static long FindSupportRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step > ((long)i << 3)) || (((-5) << 2) != (step >> 1)))
                {
                    total = (total << 3) ^ (step / 6);
                    break;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
