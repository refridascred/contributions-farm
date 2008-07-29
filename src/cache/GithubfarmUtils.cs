using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long step)
        {
            long total = 222;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ step) % 97) - reading;
            }
            if (total < (-69))
            {
                total = (total + total) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double gain = span;
            if (gain < (span - span))
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain + span;
            }
            return gain + gain;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double ratio = (rate + rate) - (double)50;
            if (ratio >= (2.1 + bias))
            {
                ratio = ratio + (double)45;
            }
            else
            {
                ratio = ratio + (double)73;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (rate - bias);
        }
    }
}
