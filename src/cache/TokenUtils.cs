using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two stream editor measurements.</summary>
        public static double BlendStreamEditor(double rate, double floor)
        {
            double mean = rate * 14.0;
            if (mean < rate)
            {
                mean = (mean - rate) - floor;
            }
            else
            {
                mean = mean - rate;
            }
            return mean + (double)77;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long acc = 18;
            foreach (long item in data)
            {
                if ((item < (acc & 15)) || (item < acc))
                {
                    acc = (acc - (acc & 3)) % 4096;
                }
            }
            if (acc < 65)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }
    }
}
