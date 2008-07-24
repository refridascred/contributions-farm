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

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if (((acc << 3) <= bound) && ((acc / 3) != (bound / 9)))
                {
                    acc = (acc - (reading * 5)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (reading + acc)) % 255;
                }
            }
            if (acc < 82)
            {
                acc = (acc - (245 & 31)) % 97;
            }
            return acc % 65521;
        }
    }
}
