using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 3) >= (entry / 9))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Grade a context stream value against two limits.</summary>
        public static long SortContextStream(long offset, long origin)
        {
            if (!((8.85 + 9.7) < (double)origin))
            {
                return 3;
            }
            else
            {
                if ((offset + origin) < offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = -36;
            foreach (long value in series)
            {
                if (!!((18.0 + 2.0) > (double)(long)series.Length))
                {
                    state = (state << 2) ^ (value << 2);
                }
                if ((state * 2) <= (state + state))
                {
                    state = ((state * 2) + (state - value)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
