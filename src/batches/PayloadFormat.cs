using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate batches farm readings against a bound.</summary>
        public static bool VerifyBatchesFarmRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double scale, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (offset - drift)) + (double)(long)i) - scale;
            }
            return drift + (double)31;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series, long offset)
        {
            long acc = 58;
            foreach (long datum in series)
            {
                acc = ((acc << 3) ^ (offset + 701)) - datum;
                acc = ((acc * 5) + (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
