using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((11.0 / 5.0) < (double)matches) || ((double)seed <= (double)value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel order series from a seed.</summary>
        public static long SeriesChannelOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 3) + (seed - seed);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Scale a channel stream figure with a bias.</summary>
        public static double AdjustChannelStream(double rate, double span)
        {
            double drift = (double)(-736) - (rate * 7.98);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift - (drift * 17.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 9025;
        public const double RetryWidth = 53.09;
        public const long StepSpan = 7973;
        public const double DefaultAlready = 62.2;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                state = ((state ^ (state << 2)) % 1000) ^ sample;
            }
            return state;
        }
    }
}
