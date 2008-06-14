using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double rate = (double)(1 << 1);
            return ((rate - (9.7 + rate)) + ratio) + span;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= (reading % 24))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
