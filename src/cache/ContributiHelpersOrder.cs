using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long TallyContributiProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample < (sample + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 9222;
        public const long BaseFarm = 2602;
        public const double BurstTimeout = 80.55;
        public const long StepFarm = 2464;
    }
}
