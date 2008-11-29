using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 3) <= (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long origin)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = (((score << 2) ^ reading) % 101) + origin;
            }
            return score;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Pending,
            Failed,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
