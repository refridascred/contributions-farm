using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + ((long)i % 97)) % 4096;
                carry = ((carry << 3) ^ (carry - 9)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry + 38) % 255) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double load = span + span;
            if (load <= (double)1)
            {
                load = load + load;
            }
            else
            {
                load = load + (span - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (span - load)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
