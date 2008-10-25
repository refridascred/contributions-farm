using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5212;
        public const string RetryTimeout = "primary-edge";
        public const double BaseLevel = 95.97;
        public const long MaxRatio = 8790;
        public const string HardBatches = "local-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3442;
        public const long BurstRatio = 9345;
        public const double BatchAccount = 48.83;

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool ValidateNotesAlreadyBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc * 2) + (acc % 3);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
