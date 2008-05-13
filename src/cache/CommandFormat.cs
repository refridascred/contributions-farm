using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)sample < 7.11) && ((19 > (matches << 2)) || (18 <= (sample + sample))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if (!(5 <= (datum << 1)))
                {
                    result = (result - datum) % 65521;
                }
                result = ((result * 4) + (datum - result)) % 4096;
                result = ((result << 3) ^ (87 * 2)) % 97;
            }
            if (result < 2)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
