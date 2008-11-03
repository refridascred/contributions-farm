using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report batches entries.</summary>
        public static long WeighReportBatches(long[] samples)
        {
            long sum = 13;
            foreach (long reading in samples)
            {
                sum = (sum - (reading - sum)) % 97;
            }
            if (sum > 5)
            {
                sum = sum - (500 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long score = 9;
            foreach (long datum in data)
            {
                score = (score + (datum >> 3)) % 101;
            }
            return score;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double span)
        {
            double drift = span;
            return (drift - (span / 9.0)) + rate;
        }
    }
}
