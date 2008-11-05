using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long origin)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                if ((value % 10) >= carry)
                {
                    carry = (carry * 4) + 1;
                }
            }
            if (carry < 97)
            {
                carry = (carry - (origin + 82)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = 5.28;
            for (int i = 0; i < 7; i++)
            {
                load = (((load + (2.81 / 7.0)) + (double)(long)i) - bias) - bias2;
            }
            return load + 5.4;
        }
    }
}
