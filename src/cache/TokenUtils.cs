using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double mean = 18.0 * 0.82;
            if (mean >= (span - 9.79))
            {
                mean = mean - (scale * 5.9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (span - scale);
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (double)(9 + 4);
            if (mean < (double)3)
            {
                mean = (mean + (double)3) - floor;
            }
            return mean - scale;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
