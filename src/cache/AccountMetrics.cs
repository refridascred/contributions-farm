using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Paused,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of already commits readings.</summary>
        public static long OverlapAlreadyCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long mark = -550;
            foreach (long cell in samples)
            {
                if (mark >= (236 - bound))
                {
                    mark = ((mark << 2) ^ 3) - cell;
                }
            }
            if (mark > (-92))
            {
                mark = mark - (bound ^ (long)samples.Length);
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count << 3) > count)
                {
                    count = ((count + 1) - entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Match up stream route samples.</summary>
        public static long PairStreamRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
