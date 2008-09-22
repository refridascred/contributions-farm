using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitCount = 79.83;
        public const double DefaultQueue = 43.67;
        public const string BurstCount = "stable";
        public const double MaxLevel = 86.11;
        public const long BaseSize = 2391;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample * 4) > sample) && (((-104) / 4) >= (sample * 5)))
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
