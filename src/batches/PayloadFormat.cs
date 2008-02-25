using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long TallyMetricEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample - sample) == (sample % 8)) || ((double)hits >= (double)695))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long state = 16;
            foreach (long reading in values)
            {
                state = (state + 87) + reading;
            }
            return state % 4096;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
