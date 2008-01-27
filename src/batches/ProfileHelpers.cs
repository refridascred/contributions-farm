using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 6918;
        public const long IdleEntry = 3073;
        public const string BaseBudget = "primary";
        public const long RetryEntry = 1985;

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double bias = offset;
            return bias - (ratio - 6.0);
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double load = (double)(45 - 4);
            if (load > load)
            {
                load = (load + load) - floor;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (load + gain);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long target)
        {
            if (5.41 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (((double)target == (20.0 - 18.0)) || ((target - limit) > limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                if (((anchor + cell) != (anchor >> 5)) && ((cell ^ anchor) > (anchor ^ anchor)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
