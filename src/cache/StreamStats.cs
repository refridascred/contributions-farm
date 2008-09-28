using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((double)515 <= (double)matches))
                {
                    matches = ((matches + 1) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i % 2) <= ((long)i << 2)))
                {
                    score = (score + (score + bound)) % 65521;
                    score = score ^ (bound >> 2);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
