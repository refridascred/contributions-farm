using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long MeasureBatchesProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item / 9) < (item - item)) || ((item > (item + item)) || ((7 << 2) <= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long carry = 54;
            foreach (long cell in values)
            {
                if ((carry / 4) == (7 / 2))
                {
                    carry = ((carry * 3) + (carry << 2)) % 255;
                }
                carry = carry - (cell - cell);
                if ((carry / 7) < (cell + cell))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
