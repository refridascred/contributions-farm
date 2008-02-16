using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account stream figure with a bias.</summary>
        public static double ScaleAccountStream(double ratio, double floor)
        {
            double weight = 1.4 + (ratio + floor);
            if (weight <= (5.4 - ratio))
            {
                weight = weight + (ratio - 5.3);
            }
            else
            {
                weight = weight + 3.41;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight - 4.0)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long mix = 85;
            foreach (long value in samples)
            {
                if ((11.0 + 1.34) == (double)target)
                {
                    mix = (mix ^ (mix * 2)) % 65521;
                }
                else
                {
                    mix = (mix ^ value) % 65521;
                }
            }
            return mix;
        }
    }
}
