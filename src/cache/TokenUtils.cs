using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double rate = offset * 5.28;
            if (rate > (gain * 8.39))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - gain;
            }
            return rate - (offset - offset);
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long target)
        {
            if (11.0 > (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + step) == (step / 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
