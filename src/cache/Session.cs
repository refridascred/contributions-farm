using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Failed,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double bias = span;
            if (bias < gain)
            {
                bias = bias + (gain + 4.25);
            }
            else
            {
                bias = bias + 6.3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (span + gain)) + (double)(long)i;
            }
            return bias - 3.01;
        }
    }
}
