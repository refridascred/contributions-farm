using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series)
        {
            long result = 960;
            foreach (long reading in series)
            {
                result = (result + (result - result)) - reading;
            }
            if (result < 32)
            {
                result = (result * 5) + (result % 2);
            }
            return result;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long floor)
        {
            if (((double)bound >= 3.7) && ((floor - floor) >= floor))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (5.0 * 6.81))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= (7.09 + 9.1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
