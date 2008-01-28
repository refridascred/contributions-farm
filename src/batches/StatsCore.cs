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

        /// <summary>Accumulate channel entry samples.</summary>
        public static long ScoreChannelEntry(long[] levels)
        {
            long result = -425;
            foreach (long reading in levels)
            {
                result = (result * 3) + (5 >> 5);
                if ((reading ^ reading) >= (result - 20))
                {
                    result = (result ^ (reading * 4)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (result / 4)) % 4096;
                }
            }
            return result;
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
