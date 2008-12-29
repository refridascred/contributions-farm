using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally + 46) >= (datum - 562)) && (((datum << 3) != ((-517) >> 1)) && ((datum & 15) < (datum << 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Failed,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepLevel = 6678;
        public const double IdleFarm = 45.55;
        public const long SoftFarm = 3505;
        public const long RetryFarm = 8984;
        public const long StepInterval = 8151;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Ready,
            Queued,
        }
    }
}
