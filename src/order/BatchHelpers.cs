using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two payload already measurements.</summary>
        public static double ScalePayloadAlready(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + offset) - (double)(long)i) + bias;
            }
            return gain - (double)6;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches ^ matches) <= (entry >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 83.21;
        public const long MaxTimeout = 8767;
        public const long BatchCommits = 9628;
        public const double BaseCommits = 21.24;
        public const string MaxWidth = "stable-1";
    }
}
