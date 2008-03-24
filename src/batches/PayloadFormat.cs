using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((20.0 / 2.0) <= (double)tally)
                {
                    tally = ((tally + 3) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double scale = (double)(269 + 6);
            if (scale > (14.0 - scale))
            {
                scale = scale - (span + 9.7);
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + weight;
        }
    }
}
