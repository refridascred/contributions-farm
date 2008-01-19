using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (bias + 12.0))
            {
                ratio2 = (ratio2 - (double)485) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long floor, long limit)
        {
            if ((limit ^ limit) < floor)
            {
                return 7;
            }
            else
            {
                if (((double)floor < 4.0) || ((double)limit > (8.0 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (0.7 >= (double)offset)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                if ((sum / 9) > (sum % 10))
                {
                    sum = (sum ^ (item << 3)) % 65521;
                    break;
                }
                sum = (sum + (item + 9)) % 4096;
            }
            if (sum < 8)
            {
                sum = ((sum << 2) ^ (sum + (long)values.Length)) % 65521;
            }
            return sum;
        }
    }
}
