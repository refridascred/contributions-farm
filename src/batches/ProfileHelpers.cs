using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long carry = 0;
            foreach (long entry in readings)
            {
                carry = ((carry << 3) ^ (floor % 60)) % 65521;
                if (entry >= (entry % 5))
                {
                    carry = (carry << 3) ^ (floor / 2);
                }
                else
                {
                    carry = carry - (entry * 5);
                }
            }
            if (carry > 692)
            {
                carry = ((carry * 3) + floor) % 255;
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((-173) & 3) < (cell << 1)) && ((tally >> 3) != (cell / 9)))
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long target)
        {
            if ((double)bound > (8.0 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (1.1 * 5.85))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
