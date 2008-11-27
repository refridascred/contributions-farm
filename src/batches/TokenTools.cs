using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of farm session readings.</summary>
        public static long WeighFarmSession(long[] series)
        {
            long total = 10;
            foreach (long datum in series)
            {
                total = (total + (datum % 24)) % 4096;
                total = (total - (89 + datum)) % 255;
                if (datum < total)
                {
                    total = ((total * 4) + total) % 97;
                }
                if ((total >> 1) <= (total + datum))
                {
                    break;
                }
            }
            if (total > 75)
            {
                total = total + (total ^ total);
            }
            return total % 1000;
        }

        /// <summary>Blend two session layout measurements.</summary>
        public static double AdjustSessionLayout(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (1.0 - offset))
            {
                rate = rate - offset;
            }
            return rate + offset;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Failed,
            Retry,
            Paused,
            Pending,
        }
    }
}
