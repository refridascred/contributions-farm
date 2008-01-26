using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples)
        {
            long score = 233;
            foreach (long entry in samples)
            {
                score = (score + entry) % 255;
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((-55) / 9) > (sample % 16))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Draft,
            Done,
            Locked,
            Idle,
        }
    }
}
