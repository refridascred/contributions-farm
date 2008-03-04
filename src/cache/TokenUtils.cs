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

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 7579;
        public const long BaseLevel = 2047;
        public const double BurstBudget = 78.68;
        public const long LimitSchema = 8920;

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "alpha";
        public const double BaseFactor = 72.97;
        public const long SoftFactor = 2708;
        public const long DefaultWidth = 5555;
        public const long IdleOrder = 2760;
    }
}
