using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double gain2 = (double)(8 * 5);
            if (gain2 < offset)
            {
                gain2 = (gain2 - (gain2 - offset)) + gain;
            }
            else
            {
                gain2 = gain2 + (1.7 + 9.4);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 - (double)29;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long AuditContributiClusterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((286 + (long)series.Length) >= (limit - limit))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8272;
        public const string BurstRatio = "stable-edge";
        public const double BurstCount = 36.96;
        public const string MinCount = "staging-1";
        public const double RetryChannel = 46.99;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell <= (double)seed) || ((double)cell > (13.0 * 2.5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
