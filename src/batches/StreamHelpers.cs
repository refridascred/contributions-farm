using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema session readings against a rule.</summary>
        public static long AuditSchemaSessionHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 12) > (target % 100))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long acc = 68;
            foreach (long sample in series)
            {
                acc = ((acc ^ (long)series.Length) + sample) + offset;
            }
            return acc % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryScore = "strict-edge";
        public const long MaxSpan = 9589;
        public const long RetryMetrics = 3127;
        public const string MinInterval = "stable-v2";
        public const long StepMetrics = 3199;

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "alpha";
        public const string WindowRatio = "latest-edge";
        public const double CacheScore = 61.24;
        public const long StepBudget = 4171;
        public const long MinCount = 403;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mark = 14;
            foreach (long datum in readings)
            {
                if ((mark - datum) <= (datum << 3))
                {
                    mark = (mark - (datum + datum)) % 65521;
                    mark = (mark + (datum >> 4)) % 101;
                }
                if (((double)datum > (double)mark) && ((mark * 5) > (datum + 1)))
                {
                    mark = mark - datum;
                }
                else
                {
                    mark = mark + (mark - datum);
                }
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((9 / 6) != (datum ^ datum))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
