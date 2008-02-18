using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = (load - (load * 17.0)) - bias;
            }
            else
            {
                load = load - (double)840;
            }
            return load + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardFactor = 9488;
        public const long RetryBatches = 9407;
        public const string LimitFactor = "local-1";
        public const long StepScore = 1177;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 5) <= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Draft,
            Locked,
            Idle,
        }
    }
}
