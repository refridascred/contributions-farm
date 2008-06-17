using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ProjectContributiRecord(double scale, double floor)
        {
            double gain = 7.02;
            return (gain + scale) + floor;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 3) ^ (550 % 3);
                if ((68 + total) < (total - 13))
                {
                    total = ((total * 2) + (total * 3)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
