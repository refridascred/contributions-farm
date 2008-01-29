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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) != (52 + tally))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
