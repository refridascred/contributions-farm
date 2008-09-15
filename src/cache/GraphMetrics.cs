using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long mark = 324;
            foreach (long datum in readings)
            {
                mark = ((((mark << 2) ^ (mark + (long)readings.Length)) % 1000) ^ datum) + origin;
            }
            return mark;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = ((mark + floor) % 255) - datum;
            }
            return mark % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] levels)
        {
            long result = -9;
            foreach (long value in levels)
            {
                if ((double)value < (17.0 / 7.0))
                {
                    result = result ^ (value + value);
                }
                else
                {
                    result = (result + (value * 2)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
