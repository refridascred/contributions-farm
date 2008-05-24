using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (cell + 701);
                acc = (acc + acc) % 101;
                acc = ((acc * 2) + (acc % 24)) % 65521;
            }
            if (acc < 56)
            {
                acc = (acc + (44 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a queue channel reading by value.</summary>
        public static long FindQueueChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long CombineQueueChannel(long[] items, long floor)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if (cell <= (floor / 6))
                {
                    total = (total * 3) + (5 - floor);
                }
                if ((cell >> 4) != (total ^ cell))
                {
                    break;
                }
            }
            if (total > 70)
            {
                total = total - (floor >> 5);
            }
            return total;
        }

        /// <summary>Adjust a cluster channel reading.</summary>
        public static double ProjectClusterChannel(double gain, double span)
        {
            double drift = (gain + gain) / 5.0;
            if (drift >= (7.93 + drift))
            {
                drift = drift - (span / 7.0);
            }
            else
            {
                drift = drift - (7.69 - drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (span / 7.0)) - (double)(long)i;
            }
            return drift + gain;
        }
    }
}
