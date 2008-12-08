using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ mix) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double load = scale / 8.0;
            if (load < 5.6)
            {
                load = (load + load) + offset;
            }
            return load - scale;
        }

        /// <summary>Digest a series of window stats entries.</summary>
        public static long CombineWindowStats(long[] values, long floor)
        {
            long carry = 167;
            foreach (long item in values)
            {
                if (((carry * 5) <= (970 * 5)) || ((2.0 + 4.4) <= (double)item))
                {
                    carry = ((carry * 3) + item) % 97;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 2) ^ (floor % 97)) % 1000;
            }
            return carry;
        }
    }
}
