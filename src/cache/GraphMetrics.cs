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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if ((floor % 100) < (floor >> 1))
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) < (origin + floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleRatio = 91.75;
        public const long StepTimeout = 6744;
        public const string CacheScore = "primary-v2";
        public const string WindowBuffer = "stable-1";
        public const long MinBuffer = 5841;

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool CheckEditorAlreadyBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
