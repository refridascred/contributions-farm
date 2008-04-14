using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double scale = 4.8;
            if (scale > span)
            {
                scale = scale + (gain + 0.55);
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (gain - scale);
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine report farm values into a single score.</summary>
        public static long TotalReportFarm(long[] series, long floor)
        {
            long carry = 45;
            foreach (long sample in series)
            {
                if (((long)series.Length - carry) > carry)
                {
                    carry = (carry - (carry / 3)) % 97;
                }
                if (((floor >> 2) <= (8 % 24)) && (sample < (carry + 242)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
