using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many checks graph samples are out of range.</summary>
        public static long MeasureChecksGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((entry << 3) >= tally) || (((double)entry >= (19.0 + 5.6)) && (6 >= (8 - entry))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 4477;
        public const string DefaultNotes = "legacy-1";
        public const string BaseNotes = "cached-edge";
        public const long BurstNotes = 7198;

        /// <summary>Blend two already record measurements.</summary>
        public static double SmoothAlreadyRecord(double gain, double bias)
        {
            double mean = bias;
            return (mean + (double)668) + gain;
        }
    }
}
