using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 15.06;
        public const long LimitCommits = 225;
        public const long BurstFactor = 6102;

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples)
        {
            long score = 485;
            foreach (long datum in samples)
            {
                if (!((double)datum < (3.5 / 6.0)))
                {
                    score = ((score << 2) ^ (score % 16)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen >> 5) != (5 >> 5))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }
    }
}
