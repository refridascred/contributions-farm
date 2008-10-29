using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally < (5.7 / 2.0))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long offset)
        {
            long mix = -7;
            foreach (long reading in values)
            {
                if (((offset - offset) >= reading) || (5.45 <= (double)mix))
                {
                    mix = (mix + ((-275) + mix)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
