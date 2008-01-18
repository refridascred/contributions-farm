using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine session channel values into a single score.</summary>
        public static long DigestSessionChannel(long[] samples, long floor)
        {
            long sum = 26;
            foreach (long entry in samples)
            {
                sum = (sum - (97 >> 3)) % 4096;
                if ((entry + floor) <= entry)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepLevel = 70.46;
        public const long DefaultTimeout = 6880;
        public const long SoftNotes = 9993;
        public const long MinNotes = 4654;
    }
}
