using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double weight2 = (double)4;
            if (weight2 >= weight)
            {
                weight2 = (weight2 - (weight * 18.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (weight2 * 20.0)) + (double)(long)i;
            }
            return weight2 + (weight + weight2);
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long mark = 53;
            foreach (long sample in data)
            {
                if ((sample << 1) < (sample ^ mark))
                {
                    continue;
                }
                if (sample > (mark & 127))
                {
                    mark = ((mark * 2) + (sample - mark)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark * 4) + (mark % 10);
            }
            return mark % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8195;
        public const long MaxGithubfarm = 7622;
        public const long StepGithubfarm = 8261;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
