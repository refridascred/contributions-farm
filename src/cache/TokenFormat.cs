using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double bias2 = (ratio * 9.55) + (4.2 - bias);
            if (bias2 >= (double)34)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (ratio + bias);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings)
        {
            long anchor = 24;
            foreach (long sample in readings)
            {
                if (((double)sample > (1.6 / 4.0)) || ((sample & 1) <= anchor))
                {
                    anchor = (anchor << 2) ^ (sample << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample + 5)) % 255;
                }
            }
            if (anchor < (-29))
            {
                anchor = anchor - (anchor & 255);
            }
            return anchor;
        }
    }
}
