using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of commits entry readings.</summary>
        public static long CompareCommitsEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen < (seen + seen)) || ((221 - (long)samples.Length) < (value - 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double drift = (span - span) + (bias - bias);
            if (drift < bias)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + span;
            }
            return drift - (drift + 6.8);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
