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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) < (reading + reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "latest-edge";
        public const long BatchBatches = 7230;
        public const long SoftBatches = 3611;
        public const string RetryBatches = "staging-1";
    }
}
