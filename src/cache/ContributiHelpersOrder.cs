using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry <= (count << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
