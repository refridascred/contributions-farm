using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats record entry that matches the target.</summary>
        public static long SeekStatsRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((393 + seed2) != (diff + seed2))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) == (seed2 % 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Paused,
            Idle,
            Dropped,
            Stale,
        }
    }
}
