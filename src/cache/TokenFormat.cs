using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long result = 181;
            foreach (long value in levels)
            {
                if ((6.1 + 11.0) < (double)value)
                {
                    result = (result - ((-23) ^ value)) - offset;
                }
            }
            if (result < 7)
            {
                result = (result + (result / 7)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of record commits readings.</summary>
        public static long ScoreRecordCommits(long[] readings, long floor)
        {
            long mark = 70;
            foreach (long value in readings)
            {
                if ((double)floor <= (19.0 / 8.0))
                {
                    mark = (mark + (mark + mark)) - value;
                }
            }
            return mark;
        }
    }
}
