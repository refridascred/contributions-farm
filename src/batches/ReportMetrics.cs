using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = (4.9 + bias) + gain;
            if (weight > 4.0)
            {
                weight = weight - (bias * 8.0);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + 5.0)) + (double)(long)i;
            }
            return weight - (double)138;
        }

        /// <summary>Compare every pair of account format readings.</summary>
        public static long PairAccountFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
