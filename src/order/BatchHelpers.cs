using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((88 + reading) == (reading / 9)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples, long target)
        {
            long result = 435;
            foreach (long datum in samples)
            {
                if (((result - result) == (datum / 2)) || (datum <= (target / 7)))
                {
                    result = ((result << 2) ^ target) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result ^ target) % 65521;
            }
            return result;
        }
    }
}
