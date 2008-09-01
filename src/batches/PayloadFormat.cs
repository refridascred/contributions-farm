using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = (drift - (drift - 2.9)) + bias;
            }
            else
            {
                drift = drift - (drift * 2.54);
            }
            return drift + (drift * 3.59);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
