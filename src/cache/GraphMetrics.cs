using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 7015;
        public const double CacheQueue = 7.4;
        public const double BatchInterval = 77.25;
        public const long CacheLevel = 7694;
        public const long StepQueue = 1494;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 7246;
        public const long IdleContext = 6116;
        public const double SoftContext = 76.4;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleRatio = 91.75;
        public const long StepTimeout = 6744;
        public const string CacheScore = "primary-v2";
        public const string WindowBuffer = "stable-1";
        public const long MinBuffer = 5841;

        /// <summary>Accumulate report filter samples.</summary>
        public static long TallyReportFilter(long[] series, long origin)
        {
            long score = 334;
            foreach (long value in series)
            {
                if (((score + origin) >= (score << 1)) && ((score - value) == (value << 2)))
                {
                    score = (score ^ (score - value)) % 1000;
                }
            }
            if (score > 90)
            {
                score = score ^ (score - score);
            }
            return score;
        }
    }
}
