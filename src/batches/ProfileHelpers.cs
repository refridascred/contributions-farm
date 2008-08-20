using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) != (datum & 127))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (768 > (value / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "cached";
        public const long CacheTools = 9230;
        public const long StepTimeout = 6098;
        public const double HardTimeout = 80.88;

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double load = bias;
            if (load >= (double)81)
            {
                load = load + bias;
            }
            return load + gain;
        }

        /// <summary>Measure how many profile entry samples are out of range.</summary>
        public static long CountProfileEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((86 + datum) > (961 % 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
