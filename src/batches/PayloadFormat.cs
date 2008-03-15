using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many graph order samples are out of range.</summary>
        public static long MeasureGraphOrderGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((7.7 * 16.0) != (double)floor)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((3.0 - 2.6) < (double)matches)
                {
                    matches = ((matches + 2) + reading) + bound;
                }
            }
            return matches;
        }
    }
}
