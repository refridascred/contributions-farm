using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double mean = scale;
            if (mean <= 6.06)
            {
                mean = (mean - scale) - floor;
            }
            return mean - (mean + 4.0);
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double ratio, double span)
        {
            double weight = (ratio - span) / 3.0;
            if (weight <= (double)651)
            {
                weight = weight - (double)65;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - (weight - span);
        }
    }
}
