using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter format samples.</summary>
        public static long CompareFilterFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally + datum) < bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long ScoreAccountFilter(long[] data)
        {
            long carry = 429;
            foreach (long value in data)
            {
                if ((72 / 6) >= (carry ^ value))
                {
                    carry = (carry - 38) % 4096;
                }
            }
            if (carry < 403)
            {
                carry = (carry * 4) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long sum = 115;
            foreach (long entry in samples)
            {
                long gap = entry;
                if (((sum + gap) == ((long)samples.Length << 1)) || (gap > (gap >> 4)))
                {
                    sum = sum + gap;
                }
                else
                {
                    sum = sum - (sum % 12);
                }
                sum = (sum - (sum + entry)) % 101;
            }
            return sum;
        }
    }
}
