using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double scale = bias;
            if (scale <= (6.5 - span))
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)6) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((seed - 619) <= seed)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
