using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many batches contributi samples are out of range.</summary>
        public static long MeasureBatchesContributiGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item / 2) < (35 + 7))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long anchor = 612;
            foreach (long datum in values)
            {
                if ((datum * 2) > (datum + datum))
                {
                    anchor = ((anchor * 5) + (4 ^ 9)) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (7 + anchor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally <= (4.68 * 4.0))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
