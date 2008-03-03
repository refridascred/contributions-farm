using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double mean = floor - floor;
            return mean + (ratio / 8.0);
        }

        /// <summary>Roll a commits route counter forward.</summary>
        public static long RollCommitsRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double bias)
        {
            double drift = gain - (gain / 3.0);
            if (drift > (bias - bias))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift + (drift * 8.0);
            }
            return drift - gain;
        }
    }
}
