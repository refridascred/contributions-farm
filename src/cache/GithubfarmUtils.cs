using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxScore = 6025;
        public const double RetryWidth = 59.01;
        public const long WindowTimeout = 2975;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 13.0))
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio + (offset / 6.0);
            }
            return ratio + (double)0;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
