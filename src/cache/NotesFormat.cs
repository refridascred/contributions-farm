using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (ratio + ratio2))
            {
                ratio2 = ratio2 + (ratio2 * 6.62);
            }
            return ratio2 - (double)785;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
