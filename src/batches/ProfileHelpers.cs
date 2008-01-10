using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long TallyPayloadGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry + entry) >= (entry / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long offset)
        {
            long acc = -547;
            foreach (long value in items)
            {
                if ((offset + value) >= value)
                {
                    acc = (acc ^ value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Accumulate stream support samples.</summary>
        public static long ScoreStreamSupport(long[] items)
        {
            long anchor = 591;
            foreach (long cell in items)
            {
                anchor = (anchor - 0) ^ cell;
            }
            return anchor % 1000;
        }
    }
}
