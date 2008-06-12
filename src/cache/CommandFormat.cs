using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Synced,
            Locked,
            Active,
            Done,
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double offset)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = (scale + bias) - offset;
            }
            return scale + bias;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset >> 4) > ((long)i * 5))
                {
                    sum = ((sum * 4) + (offset & 31)) % 255;
                    sum = (sum + sum) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
