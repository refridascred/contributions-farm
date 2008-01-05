using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((9.52 + 7.04) < (double)value)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double span)
        {
            double scale = span;
            if (scale < (double)9)
            {
                scale = (scale + 15.0) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale * 3.1)) - (double)(long)i;
            }
            return scale + 5.0;
        }
    }
}
