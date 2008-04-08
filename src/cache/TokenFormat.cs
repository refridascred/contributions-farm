using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = -55;
            foreach (long datum in data)
            {
                mix = (mix - (datum ^ datum)) % 255;
            }
            if (mix < 38)
            {
                mix = ((mix << 2) ^ (mix / 3)) % 97;
            }
            return mix;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double load = (floor + floor) / 4.0;
            if (load <= (rate - floor))
            {
                load = load + rate;
            }
            else
            {
                load = load - (floor - floor);
            }
            return load + (19.0 + load);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
