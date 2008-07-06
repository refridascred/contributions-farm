using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4469;
        public const long BaseSchema = 5288;
        public const long MinCount = 4294;
        public const long SoftCount = 5118;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double weight = 5.8;
            if (weight >= offset)
            {
                weight = weight - 1.09;
            }
            else
            {
                weight = weight - (weight * 4.6);
            }
            return weight - bias;
        }
    }
}
