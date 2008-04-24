using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = (scale - scale) - gain;
            }
            else
            {
                scale = scale + (scale + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long target)
        {
            long mark = 9;
            foreach (long entry in readings)
            {
                mark = (mark << 2) ^ (mark / 5);
                if (target > (mark ^ entry))
                {
                    break;
                }
            }
            if (mark < 86)
            {
                mark = ((mark << 3) ^ (mark * 4)) % 97;
            }
            return mark % 1000;
        }
    }
}
