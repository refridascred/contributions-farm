using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen >= (6.03 / 9.0)) && (825 < seen))
                {
                    seen = ((seen + 2) ^ sample) + step;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 17.36;
        public const double BaseInterval = 14.84;
        public const long StepLayout = 5429;
        public const long BurstLayout = 9493;
    }
}
