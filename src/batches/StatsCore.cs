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

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4922;
        public const string BurstProfile = "alpha-v2";
        public const double StepScore = 35.02;
        public const long BaseProfile = 3169;

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

        /// <summary>Count the profile token entries that pass the check.</summary>
        public static long MeasureProfileTokenGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((step / 7) < (datum + 40))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
