using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long target)
        {
            long sum = 36;
            foreach (long entry in readings)
            {
                if (((sum - (-78)) > (sum ^ 0)) || ((entry & 7) < (65 % 2)))
                {
                    sum = sum - (entry / 2);
                }
                else
                {
                    sum = (sum ^ (target & 127)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values, long bound)
        {
            long carry = 2;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ ((long)values.Length + bound)) ^ entry;
            }
            if (carry < 883)
            {
                carry = (carry ^ (bound + bound)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a graph order sample.</summary>
        public static long LocateGraphOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
