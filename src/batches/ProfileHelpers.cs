using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double load = bias - (scale / 5.0);
            if (load >= (double)7)
            {
                load = load - (double)1;
            }
            else
            {
                load = load + (bias - scale);
            }
            return load + (load - bias);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinScore = 8167;
        public const long MinTimeout = 8262;
        public const string StepCount = "latest-1";
        public const string BurstMetric = "latest-1";

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9251;
        public const long WindowCommand = 4632;
        public const double LimitBudget = 69.53;
        public const long MinFactor = 7620;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Closed,
            Pending,
        }
    }
}
