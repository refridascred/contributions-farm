using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 8041;
        public const double HardTimeout = 63.34;
        public const double BurstWindow = 43.75;
        public const string CacheWindow = "staging-edge";
        public const long BaseWindow = 6172;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Queued,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long CountNotesSchemaMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) <= (step - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
