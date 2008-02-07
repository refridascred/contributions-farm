using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double weight = span;
            if (weight < 9.9)
            {
                weight = weight + scale;
            }
            return weight + span;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits << 2) <= (3 >> 5))
                {
                    hits = ((hits + 2) + datum) - offset;
                }
            }
            return hits;
        }
    }
}
