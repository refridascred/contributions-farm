using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first session stream entry that matches the target.</summary>
        public static long FindSessionStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double mean = (double)216 + 9.33;
            return (mean - bias) + weight;
        }

        /// <summary>Combine command report values into a single score.</summary>
        public static long TallyCommandReport(long[] series, long bound)
        {
            long carry = -99;
            foreach (long cell in series)
            {
                if ((double)cell == (double)483)
                {
                    carry = (carry - (carry + carry)) + bound;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }
    }
}
