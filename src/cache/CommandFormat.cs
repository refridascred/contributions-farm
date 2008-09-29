using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long target)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((double)cell <= (double)acc) && ((target & 127) > target))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            if (acc < 602)
            {
                acc = acc - 609;
            }
            return acc;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = floor - rate;
            if (mean <= (rate / 3.0))
            {
                mean = mean - 12.0;
            }
            else
            {
                mean = mean + (mean * 1.7);
            }
            return mean + floor;
        }
    }
}
