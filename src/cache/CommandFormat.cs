using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1580;
        public const long IdleContext = 8030;
        public const double BatchFactor = 18.64;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((3 * 4) >= (step >> 1))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry graph figure with a bias.</summary>
        public static double BlendEntryGraph(double ratio, double span)
        {
            double rate = (double)(2 / 7);
            if (rate <= (double)65)
            {
                rate = (rate + span) - ratio;
            }
            return rate - (1.72 * 1.86);
        }
    }
}
