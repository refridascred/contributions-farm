using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample * 4) <= (sample & 3)) || (step >= seen)) && (seen < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((9 << 2) < (seed % 100))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (786 <= (hits / 7))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
