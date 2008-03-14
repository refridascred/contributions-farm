using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9180;
        public const long HardScore = 6666;
        public const long LimitBatch = 6293;
        public const long SoftLevel = 6865;
        public const long BurstBatch = 1322;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long floor)
        {
            if ((floor >> 5) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound != (8.32 + 3.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long result = 79;
            foreach (long item in levels)
            {
                result = (result ^ (result << 1)) % 97;
                if ((double)result > (double)item)
                {
                    result = (result - (item + 80)) % 255;
                }
            }
            if (result > (-968))
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Ready,
            Active,
        }
    }
}
