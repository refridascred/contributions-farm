using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Accumulate route channel samples.</summary>
        public static long DigestRouteChannel(long[] samples)
        {
            long total = 48;
            foreach (long reading in samples)
            {
                if ((98 + total) == (reading % 97))
                {
                    total = ((total * 3) + (152 + total)) % 4096;
                }
            }
            if (total > 4)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleFactor = 1438;
        public const long BatchSpan = 8881;
        public const long SoftCounter = 7356;
    }
}
