using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((carry <= (floor << 3)) || ((long)i == ((long)i >> 2)))
                {
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = (carry + (132 + floor)) % 65521;
                    carry = carry ^ (floor - floor);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double load = (double)134;
            return ((load - 4.07) + rate) + floor;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = carry - (floor % 5);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
