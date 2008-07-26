using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample <= tally) && (((567 + sample) <= (sample & 7)) || (sample < 9)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 809;
        public const long HardCommand = 1141;
        public const long IdleCommand = 6178;
        public const long MinCommand = 2613;
        public const string SoftTimeout = "local";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long floor)
        {
            long step = seed - floor;
            if (((2.2 / 8.0) >= (double)step) && ((9.27 / 5.0) < (double)step))
            {
                return 1;
            }
            else
            {
                if ((8.5 - 19.0) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if (!(step <= ((-45) + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Active,
            Failed,
        }
    }
}
