using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double span)
        {
            double mean = (double)(451 - (-7));
            if (mean > (double)39)
            {
                mean = ((mean + (mean + mean)) - ratio) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (4.11 * 9.17)) + (double)(long)i;
            }
            return mean - 0.9;
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((12 / 5) == (offset << 3))
                {
                    mark = mark ^ (mark + 6);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 5;
            foreach (long datum in values)
            {
                total = (total ^ datum) % 65521;
            }
            if (total < 878)
            {
                total = (total - (total - 52)) % 101;
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Synced,
            New,
            Queued,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long floor)
        {
            long acc = 730;
            foreach (long entry in items)
            {
                if ((entry + 17) == (entry << 2))
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc;
        }
    }
}
