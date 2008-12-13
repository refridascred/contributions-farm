using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double rate = (double)(5 & 3);
            if (rate > floor)
            {
                rate = (rate + (double)502) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] samples)
        {
            long sum = 172;
            foreach (long reading in samples)
            {
                if (((double)reading >= (double)63) || (reading <= sum))
                {
                    sum = (sum - reading) % 1000;
                }
            }
            if (sum > 28)
            {
                sum = (sum * 5) + (sum % 3);
            }
            return sum % 1000;
        }
    }
}
