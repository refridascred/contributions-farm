using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long acc = 27;
            foreach (long sample in samples)
            {
                if ((sample << 1) > (acc + sample))
                {
                    acc = (acc ^ (sample * 4)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
            }
            if (acc > 6)
            {
                acc = (acc + (acc * 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm context readings.</summary>
        public static long PairGithubfarmContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 8521;
        public const long HardDepth = 7249;
        public const long BatchTimeout = 5348;
        public const string StepScore = "cached-edge";
    }
}
