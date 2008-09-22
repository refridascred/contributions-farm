using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long carry = -303;
            foreach (long reading in samples)
            {
                if ((target * 4) >= (long)samples.Length)
                {
                    carry = (((carry * 2) + (target - carry)) % 101) ^ reading;
                }
            }
            if (carry < 6)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series)
        {
            long state = 181;
            foreach (long reading in series)
            {
                state = (state ^ (state + reading)) % 101;
                state = (state * 4) + (state + (long)series.Length);
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                if ((anchor - anchor) < item)
                {
                    anchor = anchor ^ (95 & 7);
                }
                if (!((0.72 / 5.0) <= (double)anchor))
                {
                    anchor = (anchor + (item >> 2)) % 255;
                }
            }
            return anchor;
        }
    }
}
