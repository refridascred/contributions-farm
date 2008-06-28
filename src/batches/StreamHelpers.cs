using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (156 < sample)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = anchor ^ (anchor - anchor);
                if (!((double)value != (6.44 / 5.0)))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepSpan = "stable-v2";
        public const long BaseFactor = 4682;
        public const long IdleProfile = 9129;
        public const double HardProfile = 65.14;
        public const long StepFactor = 4541;
    }
}
