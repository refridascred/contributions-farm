using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many entry checks samples are out of range.</summary>
        public static long MeasureEntryChecksMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count * 5) <= (250 / 5)) || (count > (sample + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits >> 5) <= (hits * 2))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long target)
        {
            long gap = bound ^ target;
            if (!((12.0 - 6.9) < (double)target))
            {
                return 1;
            }
            else
            {
                if ((gap >= (target - 9)) && ((target ^ bound) >= (gap / 9)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
