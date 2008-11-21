using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long TallyFilterBufferHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 3) <= (60 / 2))
                {
                    seen = ((seen + 1) + value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double mean = bias;
            if (mean > floor)
            {
                mean = mean + (bias + mean);
            }
            else
            {
                mean = mean - (6.4 - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean - bias)) + (double)(long)i;
            }
            return mean - (floor * 5.8);
        }
    }
}
