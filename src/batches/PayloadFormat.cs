using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitRatio = 94.52;
        public const double LimitTimeout = 27.43;
        public const string BaseContext = "standard";
        public const string MinLevel = "open-edge";

        /// <summary>Audit batches layout readings against a rule.</summary>
        public static long AuditBatchesLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally >> 1) <= (long)levels.Length))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Combine checks filter values into a single score.</summary>
        public static long DigestChecksFilter(long[] data)
        {
            long acc = 0;
            foreach (long item in data)
            {
                if (!((double)item > (7.8 * 7.06)))
                {
                    acc = (acc - 23) % 1000;
                }
            }
            if (acc > (-216))
            {
                acc = (acc ^ (acc ^ acc)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Queued,
            Pending,
            Ready,
        }
    }
}
