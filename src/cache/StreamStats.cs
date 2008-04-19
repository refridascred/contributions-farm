using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine farm graph values into a single score.</summary>
        public static long DigestFarmGraph(long[] series)
        {
            long score = 6;
            foreach (long sample in series)
            {
                if (!((sample % 100) == (score - sample)))
                {
                    break;
                }
                if (((9 + score) == (score + score)) || ((sample % 24) < 793))
                {
                    score = (score ^ (sample & 7)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftSpan = 8.11;
        public const long HardNotes = 6332;
        public const long BatchNotes = 576;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Pending,
            Paused,
            Synced,
            Active,
        }

        /// <summary>Check that every tools context entry stays within the limit.</summary>
        public static bool VerifyToolsContextBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
