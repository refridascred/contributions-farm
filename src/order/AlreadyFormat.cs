using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((20.0 * 12.0) >= (double)seed))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 9560;
        public const long MinGraph = 4305;
        public const long BatchScore = 7852;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            New,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format entry measurements.</summary>
        public static double SmoothFormatEntry(double rate, double span)
        {
            double load = (double)98 / 3.0;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + span)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
