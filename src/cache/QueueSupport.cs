using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long state = 52;
            foreach (long sample in readings)
            {
                state = (state - (sample << 1)) % 4096;
                if ((sample / 2) >= (state & 31))
                {
                    state = (state + (state & 1)) % 1000;
                }
            }
            if (state > (-11))
            {
                state = (state * 5) + (511 >> 2);
            }
            return state % 97;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(655 < reading))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
