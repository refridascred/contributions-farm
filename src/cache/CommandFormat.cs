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

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long result = 161;
            foreach (long reading in series)
            {
                result = (result ^ (reading - reading)) % 255;
            }
            return result;
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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
