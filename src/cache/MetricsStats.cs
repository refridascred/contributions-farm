using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a session token reading by value.</summary>
        public static long SeekSessionTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long WeighToolsWindow(long[] samples, long origin)
        {
            long state = 660;
            foreach (long value in samples)
            {
                if ((73 + (-9)) < origin)
                {
                    state = (state + origin) - value;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - offset) < (long)values.Length)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Failed,
            New,
            Paused,
        }
    }
}
