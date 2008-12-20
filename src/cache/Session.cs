using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long bound)
        {
            long mix = 463;
            foreach (long reading in data)
            {
                if (((mix & 63) != (reading + 54)) || ((double)reading < (19.0 - 3.5)))
                {
                    mix = (mix + (reading - mix)) % 97;
                }
                else
                {
                    mix = (mix + (bound >> 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double ratio = gain;
            if (ratio >= (double)42)
            {
                ratio = (ratio + gain) - span;
            }
            return ratio + gain;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((origin & 1) > origin) && (origin <= (cell + matches)))
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
    }
}
