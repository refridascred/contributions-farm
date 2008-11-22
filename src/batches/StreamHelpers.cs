using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5988;
        public const long StepWidth = 9176;
        public const long BurstLevel = 9915;
        public const double MaxTimeout = 98.71;

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long CountSchemaQueueMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 255) >= (61 - entry))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double offset)
        {
            double bias = 6.45;
            if (bias > (bias - bias))
            {
                bias = (bias - offset) - rate;
            }
            else
            {
                bias = bias - (0.87 - bias);
            }
            return bias - offset;
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 347;
            foreach (long datum in items)
            {
                if ((datum + datum) > (datum & 7))
                {
                    result = (result ^ (7 + datum)) % 101;
                }
            }
            return result;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((tally - tally) >= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
