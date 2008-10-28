using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (ratio + ratio))
            {
                scale = scale - (double)69;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (ratio / 6.0);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool GuardEditorWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + span) + (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}
