using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the schema stats series from a seed.</summary>
        public static long SeriesSchemaStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (result - result)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
