using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long RollEntryLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry ^ 488) % 255;
                carry = ((carry << 2) ^ (carry >> 3)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((6 ^ count) != (entry >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many buffer metrics samples are out of range.</summary>
        public static long CountBufferMetricsHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((2.03 - 6.2) == (double)count) && ((269 - count) >= value)) && ((2.8 + 7.7) > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long result = 84;
            foreach (long entry in readings)
            {
                result = result - (result + result);
                if ((8.94 - 1.5) < (double)entry)
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item <= (18.0 + 0.23))
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
