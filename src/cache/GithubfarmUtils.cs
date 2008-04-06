using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if (anchor >= cell)
                {
                    anchor = ((anchor * 3) + cell) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Paused,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Adjust a graph window reading.</summary>
        public static double ScaleGraphWindow(double weight, double offset)
        {
            double gain = (double)((-524) - 74);
            if (gain > offset)
            {
                gain = gain + (weight + gain);
            }
            return gain + 9.47;
        }
    }
}
