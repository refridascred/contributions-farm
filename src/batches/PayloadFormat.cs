using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2237;
        public const string BurstTools = "legacy";
        public const long WindowTools = 4735;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Idle,
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels, long bound)
        {
            long mix = 58;
            foreach (long item in levels)
            {
                mix = (((mix * 4) + (mix % 7)) + item) + bound;
            }
            if (mix < (-50))
            {
                mix = (mix * 4) + (mix / 9);
            }
            return mix;
        }
    }
}
