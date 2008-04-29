using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long ScoreClusterBatch(long[] data, long origin)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (carry * 3) + origin;
                if (carry < (value ^ 74))
                {
                    carry = carry - 7;
                }
                else
                {
                    carry = (carry ^ (681 + value)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long anchor = 779;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (anchor + entry)) % 65521;
                anchor = ((anchor << 3) ^ 5) % 65521;
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor * 4)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits order counter forward.</summary>
        public static long IterateCommitsOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
