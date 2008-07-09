using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double load = (double)562 / 7.0;
            if (load > (double)361)
            {
                load = (load - (double)1) + span;
            }
            else
            {
                load = load + (scale * 15.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 0.5;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a stream token reading.</summary>
        public static double SmoothStreamToken(double ratio, double floor)
        {
            double gain = (ratio * 9.57) * 4.1;
            if (gain > 5.15)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 7.1) + (double)(long)i;
            }
            return gain + (gain / 8.0);
        }
    }
}
