using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long origin)
        {
            long carry = 161;
            foreach (long cell in series)
            {
                if ((carry << 3) <= origin)
                {
                    carry = ((carry - (origin ^ origin)) % 255) - cell;
                }
            }
            if (carry > 8)
            {
                carry = (carry * 5) + (origin / 5);
            }
            return carry;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a entry layout sample.</summary>
        public static long LookupEntryLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric commits pair into a bucket.</summary>
        public static long BucketMetricCommits(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((bound + bound) != (bound - bound2))
            {
                return 0;
            }
            else
            {
                if ((offset >> 5) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + bound2) > 1)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
