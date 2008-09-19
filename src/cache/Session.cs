using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up schema metric samples.</summary>
        public static long OverlapSchemaMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally - origin) <= tally) || ((origin / 2) >= (origin >> 4)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepTimeout = "open-v2";
        public const double BurstGraph = 0.77;
        public const long CacheWidth = 2878;
        public const long BatchGraph = 6049;
        public const string StepGraph = "stable";

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) != (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
