using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm token entries.</summary>
        public static long FoldFarmToken(long[] readings, long offset)
        {
            long total = 313;
            foreach (long item in readings)
            {
                if ((8.74 / 9.0) >= (double)total)
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total ^ (total ^ item)) % 255;
                }
                if ((double)item <= (2.7 - 11.0))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = total ^ (offset + offset);
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if (!((sample / 2) != (floor ^ 25)))
                {
                    carry = (carry * 5) + floor;
                }
                if ((sample * 4) < (280 - sample))
                {
                    break;
                }
                carry = carry + (carry & 15);
                if ((floor << 3) > (floor + sample))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
