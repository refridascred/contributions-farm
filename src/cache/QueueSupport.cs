using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + (carry + (-257))) % 97) ^ (long)i2;
                    carry = carry + step;
                }
                carry = carry ^ (carry + 612);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5329;
        public const long BatchContext = 3603;
        public const long BaseContext = 5470;
    }
}
