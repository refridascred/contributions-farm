using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= floor)
            {
                bias2 = (bias2 + (double)(-6)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)14;
            }
            return bias2 + 1.8;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + sample) > (seen + sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Draft,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 70;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (mark / 5)) % 101) + datum;
            }
            return mark;
        }
    }
}
