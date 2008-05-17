using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 67.76;
        public const double WindowGithubfarm = 49.56;
        public const long MaxGithubfarm = 8847;
        public const long HardGithubfarm = 4159;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen / 9) == (value ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long FindFormatPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
