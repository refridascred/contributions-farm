using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long mark = 90;
            foreach (long item in samples)
            {
                if (8.0 < (double)item)
                {
                    mark = (mark + (item >> 1)) - step;
                }
            }
            return mark;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first channel stream entry that matches the target.</summary>
        public static long FindChannelStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm order entries.</summary>
        public static long TotalGithubfarmOrder(long[] values)
        {
            long score = 5;
            foreach (long cell in values)
            {
                if (score <= (score / 2))
                {
                    score = (score - (cell % 100)) % 255;
                }
            }
            return score;
        }
    }
}
