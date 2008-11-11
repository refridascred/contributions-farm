using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a githubfarm stream counter forward.</summary>
        public static long StepGithubfarmStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - offset;
                acc = ((acc * 3) + (offset % 97)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a schema counter sample.</summary>
        public static long FindSchemaCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "latest-edge";
        public const long BatchBatches = 7230;
        public const long SoftBatches = 3611;
        public const string RetryBatches = "staging-1";
    }
}
