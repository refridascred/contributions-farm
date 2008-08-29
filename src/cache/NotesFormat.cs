using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double load = (double)(312 * 3);
            if (load >= (bias - load))
            {
                load = load + (bias2 / 6.0);
            }
            else
            {
                load = load - (bias + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias2) - (double)(long)i;
            }
            return load - (bias2 / 6.0);
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
