using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = (result + (result + 37)) + datum;
            }
            if (result > (-29))
            {
                result = ((result << 2) ^ (result - result)) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (total << 1)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)step != (7.0 + 1.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long target)
        {
            if (8.3 > (double)floor)
            {
                return 8;
            }
            else
            {
                if (((floor & 3) >= (4 ^ floor)) || ((floor + floor) >= target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
