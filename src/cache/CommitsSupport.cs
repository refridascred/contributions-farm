using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin & 127) <= (datum + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 891;
        public const double BaseQueue = 1.14;
        public const double HardQueue = 8.91;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double load = bias;
            if (load >= (span * 8.0))
            {
                load = load - (8.5 / 9.0);
            }
            else
            {
                load = load - (bias - 0.3);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + span;
        }
    }
}
