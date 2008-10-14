using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < mean)
            {
                mean = (mean - (mean * 1.0)) - offset;
            }
            else
            {
                mean = mean + (7.57 / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean * 7.55);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series)
        {
            long total = 92;
            foreach (long sample in series)
            {
                if (total < (31 ^ sample))
                {
                    total = ((total * 3) + (0 - total)) % 65521;
                }
                if ((total & 31) < 935)
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((6.0 / 8.0) != (double)cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (double)514)
            {
                bias = (bias - (double)836) - floor;
            }
            else
            {
                bias = bias - gain;
            }
            return bias - (6.5 / 6.0);
        }
    }
}
