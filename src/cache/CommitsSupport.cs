using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Draft,
            Synced,
            Retry,
            New,
        }

        /// <summary>Audit batch buffer readings against a rule.</summary>
        public static long MeasureBatchBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)count == (3.6 / 4.0)))
                {
                    count = ((count + 1) + cell) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
