using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two record layout measurements.</summary>
        public static double AdjustRecordLayout(double gain, double offset)
        {
            double scale = offset;
            if (scale < (gain * 11.0))
            {
                scale = scale + (gain / 4.0);
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (carry + bound)) % 255;
                if (((-43) / 6) <= (carry - bound))
                {
                    carry = ((carry * 2) + carry) % 255;
                    carry = carry - (carry + bound);
                }
                else
                {
                    carry = (carry ^ 71) % 97;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step / 5) <= (item + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
