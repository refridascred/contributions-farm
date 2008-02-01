using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double rate = 20.0;
            if (rate < (10.0 * 10.0))
            {
                rate = rate - (floor * 6.1);
            }
            else
            {
                rate = rate + (3.0 / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 4.0)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine graph report values into a single score.</summary>
        public static long FoldGraphReport(long[] series)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = mark + (reading - 4);
                if (!((reading % 7) == (long)series.Length))
                {
                    mark = (mark + (39 % 8)) % 255;
                }
                if ((double)mark < (3.0 * 5.0))
                {
                    mark = mark - (reading * 4);
                }
            }
            return mark;
        }
    }
}
