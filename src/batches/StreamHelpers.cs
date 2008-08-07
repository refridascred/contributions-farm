using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double mean = (double)21 / 6.0;
            if (mean > 4.04)
            {
                mean = (mean - (weight + mean)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (double)73;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "cached-1";
        public const double BaseLayout = 67.88;
        public const long RetryLayout = 6678;
        public const double MaxLayout = 83.9;
        public const long RetrySize = 7361;

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleWidth = "standard";
        public const long LimitTools = 6374;
        public const long SoftTimeout = 75;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = -719;
            foreach (long value in series)
            {
                score = score ^ (value % 100);
            }
            if (score > 91)
            {
                score = score ^ (485 * 4);
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long result = 54;
            foreach (long sample in readings)
            {
                result = ((result * 4) + sample) % 255;
                if (result <= (result ^ result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
