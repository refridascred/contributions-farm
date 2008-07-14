using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "primary-1";
        public const double BatchFactor = 18.29;
        public const long MaxTools = 6955;

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double ratio = (double)(88 - 798);
            if (ratio < rate)
            {
                ratio = (ratio - (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (7.93 * 6.9);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long carry = 761;
            foreach (long reading in items)
            {
                carry = (carry * 3) + (reading >> 4);
            }
            return carry % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long anchor = -77;
            foreach (long reading in data)
            {
                if (anchor <= (step / 9))
                {
                    anchor = anchor - (reading % 64);
                }
                else
                {
                    anchor = anchor - step;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many cluster checks samples are out of range.</summary>
        public static long AuditClusterChecksHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 2) == (57 - matches))
                {
                    matches = ((matches + 3) - entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
