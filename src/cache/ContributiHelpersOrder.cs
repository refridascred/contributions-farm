using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 4211;
        public const double StepFactor = 5.82;
        public const long MinCount = 1271;
        public const string StepCounter = "alpha-1";
        public const long WindowFactor = 6794;

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item == (12.0 + 4.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Stale,
            Idle,
            Dropped,
        }
    }
}
