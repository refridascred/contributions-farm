using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 54.14;
        public const string HardQueue = "open";
        public const long LimitQueue = 8673;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 255;
                state = (state + (bound + bound)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first support format entry that matches the target.</summary>
        public static long SeekSupportFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values)
        {
            long state = 94;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (value - state)) % 1000;
                if (((state * 2) < (value << 2)) || ((double)state > (1.15 - 5.87)))
                {
                    state = (state << 3) ^ (298 + value);
                }
            }
            if (state > 6)
            {
                state = (state + (681 ^ 0)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            New,
            Paused,
        }
    }
}
