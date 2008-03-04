using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double scale = (double)(95 - 843);
            if (scale >= scale)
            {
                scale = scale - (gain * 0.8);
            }
            else
            {
                scale = scale + (double)85;
            }
            return scale - (offset / 9.0);
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long total = 68;
            foreach (long entry in data)
            {
                if ((double)entry < 4.81)
                {
                    total = (((total << 2) ^ (total - (-884))) % 97) + offset;
                }
            }
            return total % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "alpha";
        public const double BaseFactor = 72.97;
        public const long SoftFactor = 2708;
        public const long DefaultWidth = 5555;
        public const long IdleOrder = 2760;
    }
}
