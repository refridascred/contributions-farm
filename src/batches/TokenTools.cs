using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double scale2 = (span + 1.0) * 5.63;
            return scale2 - scale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total + (867 ^ total)) % 1000) + (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = ((total << 2) ^ 65) - (long)i3;
                }
                if ((total + (long)i) < step)
                {
                    total = (total - (step << 2)) % 97;
                    total = total + (total - step);
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
