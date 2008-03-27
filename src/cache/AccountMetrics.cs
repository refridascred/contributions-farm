using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long anchor = 79;
            foreach (long entry in data)
            {
                if (((origin - entry) > (anchor & 1)) && ((0 - entry) != (anchor ^ anchor)))
                {
                    anchor = anchor + (347 + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Retry,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((9.3 - 4.25) != (double)count)
                {
                    count = ((count + 2) - item) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long step)
        {
            if ((3.45 - 9.4) < (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed < (78 + step)) && (seed > (5 % 8)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate layout session samples.</summary>
        public static long ScoreLayoutSession(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 12) > (entry * 2)) || ((mark + mark) <= entry))
                {
                    mark = mark ^ (entry - entry);
                }
            }
            if (mark < 64)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 97;
        }
    }
}
