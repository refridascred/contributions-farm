using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
