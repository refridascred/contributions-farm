using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double drift = (bias / 6.0) - 20.0;
            if (drift <= 16.0)
            {
                drift = drift + (span - 4.23);
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (seen * 4))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report buffer sample.</summary>
        public static long LookupReportBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3237;
        public const long BaseSize = 2157;
        public const long HardChannel = 1624;

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long acc = 56;
            foreach (long cell in data)
            {
                if (63 <= (cell + 1))
                {
                    acc = acc + (cell % 12);
                }
            }
            return acc % 1000;
        }
    }
}
