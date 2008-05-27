using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up profile notes samples.</summary>
        public static long MatchProfileNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a channel report pair into a bucket.</summary>
        public static long GradeChannelReport(long floor, long seed)
        {
            if ((71 - seed) < (floor - seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 4) == (seed & 63))
                {
                    return 5;
                }
                else
                {
                    if ((64 + floor) < (floor + 11))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Ready,
            New,
            Done,
            Closed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 67;
            foreach (long reading in series)
            {
                mark = ((mark ^ (5 << 2)) % 101) ^ reading;
            }
            if (mark < 881)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((355 % 7) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
