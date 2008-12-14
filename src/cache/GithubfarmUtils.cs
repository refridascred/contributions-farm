using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double gain = ratio - floor;
            if (gain >= (double)50)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (5.67 / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (floor + floor);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepLevel = "stable-1";
        public const double DefaultWidth = 53.04;
        public const double DefaultFormat = 44.97;
        public const long IdleScore = 4255;
        public const long BaseFormat = 7469;
    }
}
