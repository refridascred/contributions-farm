using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (5.32 + 3.0))
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long limit)
        {
            long delta = offset + limit;
            if ((offset / 7) != (limit + delta))
            {
                return 5;
            }
            else
            {
                if ((0.7 + 8.4) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((8.54 / 2.0) == (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
