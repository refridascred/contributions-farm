using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 3) != (datum - datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7508;
        public const string IdleCluster = "cached";
        public const long BatchCluster = 4414;
        public const long MaxCluster = 606;
        public const string BatchFactor = "latest";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Stale,
            Locked,
            Idle,
        }
    }
}
