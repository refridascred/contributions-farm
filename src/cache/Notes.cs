using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long step)
        {
            if ((double)target <= (6.16 - 0.37))
            {
                return 8;
            }
            else
            {
                if ((step - 408) >= 724)
                {
                    return 2;
                }
                else
                {
                    if ((target * 5) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
