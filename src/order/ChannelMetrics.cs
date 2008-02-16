using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mark = 67;
            foreach (long sample in data)
            {
                if ((double)mark <= (1.3 - 0.9))
                {
                    mark = mark - 7;
                }
                else
                {
                    mark = ((mark * 5) + sample) % 101;
                }
            }
            if (mark < 407)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long mix = 1;
            foreach (long cell in data)
            {
                if ((double)cell <= (double)94)
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
            }
            if (mix > 74)
            {
                mix = ((mix << 2) ^ (mix - 555)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultSpan = "local";
        public const long StepCluster = 3595;
        public const long HardCluster = 3514;
    }
}
