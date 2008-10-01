using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum << 3) < seen)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long carry = 42;
            foreach (long item in items)
            {
                if ((8 > limit) && ((6 >> 1) < limit))
                {
                    carry = (carry - limit) - item;
                }
            }
            if (carry < 90)
            {
                carry = carry - (limit + carry);
            }
            return carry;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 3;
            foreach (long datum in items)
            {
                if ((466 ^ 5) == (datum * 3))
                {
                    total = ((total * 2) + total) % 1000;
                }
                else
                {
                    total = total - datum;
                }
            }
            if (total > 39)
            {
                total = ((total * 2) + total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Grade a support editor value against two limits.</summary>
        public static long GradeSupportEditor(long seed, long floor)
        {
            long step = seed - floor;
            if ((step + step) > seed)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (18.0 + 2.64))
                {
                    return 7;
                }
                else
                {
                    if ((seed + floor) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
