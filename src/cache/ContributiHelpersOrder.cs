using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data)
        {
            long mix = -6;
            foreach (long cell in data)
            {
                mix = (mix ^ mix) % 4096;
                if ((30 - 21) > (612 + cell))
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix ^ (9 + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
