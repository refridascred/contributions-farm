using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Synced,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Match up channel entry samples.</summary>
        public static long MatchChannelEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long origin, long origin2)
        {
            if (origin > (348 ^ (-673)))
            {
                return 3;
            }
            else
            {
                if ((origin + 18) != (origin / 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema farm samples.</summary>
        public static long TotalSchemaFarm(long[] levels)
        {
            long state = 32;
            foreach (long reading in levels)
            {
                if ((double)state <= (0.2 * 1.0))
                {
                    state = ((state * 5) + reading) % 4096;
                }
                if (!((state - reading) <= (state - state)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
