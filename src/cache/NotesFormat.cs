using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result << 2) ^ (long)i) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Scale a metrics profile figure with a bias.</summary>
        public static double AdjustMetricsProfile(double ratio, double floor)
        {
            double rate = floor;
            return (rate + (rate + 1.46)) + ratio;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
