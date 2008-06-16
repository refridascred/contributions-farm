using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Scale a already session figure with a bias.</summary>
        public static double BlendAlreadySession(double gain, double offset)
        {
            double scale = offset;
            return (scale - scale) + gain;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long bound)
        {
            long mark = 186;
            foreach (long value in data)
            {
                if ((bound >> 1) < (39 - mark))
                {
                    mark = (mark - (value >> 3)) % 4096;
                }
                if ((value ^ value) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
