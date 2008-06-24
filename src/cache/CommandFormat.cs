using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values, long floor)
        {
            long sum = -2;
            foreach (long datum in values)
            {
                if ((5 >> 1) <= (datum ^ 847))
                {
                    sum = (sum + ((-155) + 2)) % 65521;
                }
                if ((double)sum > (20.0 - 12.0))
                {
                    sum = sum ^ (floor + datum);
                }
                else
                {
                    sum = ((sum << 3) ^ (4 << 1)) % 255;
                }
            }
            if (sum > 583)
            {
                sum = (sum ^ (floor - sum)) % 97;
            }
            return sum;
        }
    }
}
