using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double span)
        {
            double mean = scale;
            if (mean <= mean)
            {
                mean = mean - (scale / 6.0);
            }
            else
            {
                mean = mean + (span * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
