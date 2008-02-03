using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of window githubfarm entries.</summary>
        public static long ScoreWindowGithubfarm(long[] series, long floor)
        {
            long acc = 2;
            foreach (long entry in series)
            {
                if (((floor % 64) > (2 + floor)) || ((floor + floor) <= 476))
                {
                    acc = (acc + entry) % 97;
                }
            }
            if (acc < 870)
            {
                acc = (acc ^ (638 + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double mean = (span + rate) / 7.0;
            if (mean > (mean / 6.0))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (span / 7.0)) + (double)(long)i;
            }
            return mean + 2.4;
        }
    }
}
