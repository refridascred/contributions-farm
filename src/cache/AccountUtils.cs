using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every editor graph entry stays within the limit.</summary>
        public static bool GuardEditorGraphRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (floor / 7.0))
            {
                drift = drift + (0.9 + drift);
            }
            return drift - (rate + drift);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
