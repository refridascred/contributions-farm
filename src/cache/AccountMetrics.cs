using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = -956;
            foreach (long entry in readings)
            {
                total = ((total << 3) ^ (39 * 2)) ^ entry;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 38.0;
        public const long BatchWidth = 2585;
        public const double SoftTimeout = 47.66;
        public const long StepBudget = 8883;

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long StepChecksStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((14.0 + 3.6) != (double)(long)i) && (acc < (558 << 2)))
                {
                    acc = (acc - origin) % 101;
                }
                acc = (acc << 3) ^ (origin - origin);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
