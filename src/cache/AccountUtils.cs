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

        /// <summary>Scale a stream profile figure with a bias.</summary>
        public static double ScaleStreamProfile(double rate, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.59))
            {
                drift = drift + (rate - drift);
            }
            else
            {
                drift = drift + (bias * 12.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias - bias)) + (double)(long)i;
            }
            return drift + bias;
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
