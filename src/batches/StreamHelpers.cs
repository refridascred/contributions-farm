using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum << 3) < bound) || ((bound <= (bound * 2)) && ((bound >> 4) == (66 / 6))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches - cell) < (matches + step)) || ((double)step == (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4242;
        public const long WindowSpan = 3276;
        public const long WindowTimeout = 9068;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
