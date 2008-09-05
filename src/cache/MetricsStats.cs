using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] samples)
        {
            long result = 220;
            foreach (long cell in samples)
            {
                if ((419 / 3) < cell)
                {
                    result = ((result << 2) ^ (6 >> 3)) % 101;
                }
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long offset)
        {
            if ((offset >= (offset + 27)) || ((offset << 2) != (offset & 1)))
            {
                return 4;
            }
            else
            {
                if ((origin << 1) < (origin ^ origin))
                {
                    return 7;
                }
                else
                {
                    if ((offset > origin) && ((5.1 / 4.0) <= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((930 & 127) >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >> 1) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
