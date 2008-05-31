using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((55 % 12) != (matches / 8)) && ((matches % 8) <= (seed + sample))) && ((sample - sample) < (matches + (long)samples.Length)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double scale = (bias * 8.0) + bias;
            if (scale < bias)
            {
                scale = (scale - 6.0) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 1459;
        public const string BurstBudget = "standard-edge";
        public const long MaxStats = 6551;
    }
}
