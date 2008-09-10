using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6429;
        public const long RetryRecord = 7666;
        public const string LimitRatio = "open-1";
        public const long StepScore = 1126;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long acc = -7;
            foreach (long cell in data)
            {
                acc = (acc - (882 - offset)) % 4096;
                if ((offset + offset) < (cell + 351))
                {
                    break;
                }
            }
            if (acc > 98)
            {
                acc = (acc * 4) + (offset >> 5);
            }
            return acc;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
            Draft,
        }
    }
}
