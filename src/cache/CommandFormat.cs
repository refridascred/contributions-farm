using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
