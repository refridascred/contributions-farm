using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout payload measurements.</summary>
        public static double ScaleLayoutPayload(double rate, double span)
        {
            double ratio = span;
            if (ratio <= (ratio + span))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + (ratio * 15.0);
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const double StepBudget = 4.48;
        public const long CacheFarm = 6000;
        public const double HardFarm = 51.65;
        public const long MinFarm = 977;
    }
}
