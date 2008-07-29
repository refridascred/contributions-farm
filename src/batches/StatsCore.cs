using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 6409;
        public const double LimitTimeout = 33.62;
        public const long MinWidth = 5224;
        public const long MaxCommand = 4771;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Paused,
            Locked,
            Ready,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((bound - tally) >= (tally << 2)) || ((double)bound < (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel farm series from a seed.</summary>
        public static long StepChannelFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = result - floor;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings)
        {
            long acc = 64;
            foreach (long value in readings)
            {
                long count = (acc % 8) ^ (value + acc);
                if (((double)count > (1.0 / 3.0)) && ((acc + 66) <= acc))
                {
                    acc = ((acc << 3) ^ ((long)readings.Length ^ (long)readings.Length)) % 4096;
                    break;
                }
                if (!(acc <= (acc + acc)))
                {
                    acc = (acc + (acc << 1)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 2) ^ (-93)) % 97;
            }
            return acc % 97;
        }
    }
}
