using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 24.53;
        public const long MinSchema = 3949;
        public const long StepSchema = 1384;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally > (double)bound)
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value != (5.0 * 6.0))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4723;
        public const long WindowCommits = 4307;
        public const long HardCommits = 1206;
        public const double MaxSpan = 72.17;
        public const long BaseTimeout = 8298;
    }
}
