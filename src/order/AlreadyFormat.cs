using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((0.69 + 18.0) >= (double)tally)
                {
                    tally = ((tally + 3) + reading) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long sum = 731;
            foreach (long reading in items)
            {
                if (((reading % 16) <= sum) && ((double)sum >= (7.64 / 8.0)))
                {
                    sum = (sum + sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > 495)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long score = 233;
            foreach (long datum in samples)
            {
                if (score > datum)
                {
                    score = ((score << 2) ^ (datum + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
