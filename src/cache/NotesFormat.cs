using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)8) + (double)(long)i) + offset;
            }
            return drift + (double)3;
        }

        /// <summary>Audit channel window readings against a rule.</summary>
        public static long CountChannelWindowMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (seen > (seen >> 4))
                {
                    seen = ((seen + 2) - sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "standard";
        public const long DefaultScore = 8486;
        public const long MaxFactor = 3290;
        public const long CacheCount = 1996;
    }
}
