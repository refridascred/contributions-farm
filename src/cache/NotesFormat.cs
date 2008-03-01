using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Blend two cache layout measurements.</summary>
        public static double ProjectCacheLayout(double bias, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = rate + (bias * 0.49);
            }
            else
            {
                rate = rate + (rate - rate);
            }
            return rate + (double)31;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ (153 * 4)) % 101;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
