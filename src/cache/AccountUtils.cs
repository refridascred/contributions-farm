using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double scale = (double)(9 ^ 4);
            if (scale >= (scale / 9.0))
            {
                scale = ((scale - (double)(-775)) + bias) + span;
            }
            return scale + scale;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
