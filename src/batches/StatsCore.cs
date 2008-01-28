using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Active,
            Locked,
            New,
        }

        /// <summary>Blend two contributi stream measurements.</summary>
        public static double SmoothContributiStream(double rate, double bias)
        {
            double bias2 = (double)48 - rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (bias2 / 8.0)) - (double)(long)i) - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double load = (double)829 + (8.0 * 5.0);
            return ((load + (double)88) + ratio) + span;
        }

        /// <summary>Accumulate batch channel samples.</summary>
        public static long DigestBatchChannel(long[] data)
        {
            long acc = 1;
            foreach (long sample in data)
            {
                acc = (acc - acc) - sample;
            }
            return acc % 4096;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Pending,
            Done,
            Failed,
            Dropped,
        }
    }
}
