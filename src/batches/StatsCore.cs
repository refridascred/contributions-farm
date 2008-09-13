using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "primary";
        public const double MaxSize = 22.86;
        public const double DefaultContext = 0.64;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7 >= target)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally > (sample % 5)) && ((sample >> 5) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Dropped,
            Ready,
            Queued,
            New,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
