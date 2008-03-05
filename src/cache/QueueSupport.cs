using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate metrics support readings against a bound.</summary>
        public static bool ValidateMetricsSupportLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
