using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total << 2) ^ (bound - total)) ^ (long)i2;
                    total = (total + (bound + total)) % 101;
                }
                total = (total ^ (total - bound)) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
