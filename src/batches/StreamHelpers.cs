using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 1581;
        public const long BatchSize = 4339;
        public const long BurstEditor = 4873;
        public const long MaxScore = 9104;

        /// <summary>Blend two window layout measurements.</summary>
        public static double ScaleWindowLayout(double ratio, double floor)
        {
            double drift = (double)(11 + 56);
            if (drift > (double)72)
            {
                drift = drift - (ratio / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (ratio - floor)) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every githubfarm session entry stays within the limit.</summary>
        public static bool ValidateGithubfarmSessionBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= (gain - offset))
            {
                gain2 = gain2 - (double)(-37);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (7.3 - gain)) + (double)(long)i;
            }
            return gain2 + offset;
        }
    }
}
