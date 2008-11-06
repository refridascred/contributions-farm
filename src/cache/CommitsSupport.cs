using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a commits farm value against two limits.</summary>
        public static long RankCommitsFarm(long target, long bound)
        {
            long gap = target - bound;
            if ((double)gap <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((gap + 6) >= (gap + gap)) && ((double)target >= 4.22))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (9.57 > (double)step)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings)
        {
            long total = 20;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                if (((long)readings.Length ^ 983) < (total ^ 763))
                {
                    total = (total ^ 659) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
