using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double ratio = gain;
            if (ratio > (double)668)
            {
                ratio = ratio + (double)18;
            }
            else
            {
                ratio = ratio - (offset - 9.25);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (5.0 * 0.96)) + (double)(long)i;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset + offset;
            if (bias2 <= (bias / 3.0))
            {
                bias2 = bias2 + (bias2 - 12.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias2 * 1.0)) + (double)(long)i;
            }
            return bias2 - (bias2 - bias2);
        }
    }
}
