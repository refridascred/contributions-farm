using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long TallyMetricChannelGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (count / 7))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "cached-edge";
        public const long MinGithubfarm = 8762;
        public const long HardScore = 7863;
        public const string StepDepth = "primary";

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long CombineContributiBatch(long[] series, long offset)
        {
            long mix = 290;
            foreach (long cell in series)
            {
                mix = ((mix - (mix + mix)) + cell) - offset;
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings, long target)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                acc = (((acc * 2) + (acc - 7)) ^ reading) - target;
            }
            return acc;
        }
    }
}
