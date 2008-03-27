using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = mark ^ limit;
                if (((datum + datum) < (limit << 2)) || ((double)mark == (3.0 * 8.69)))
                {
                    mark = (mark << 3) ^ (long)levels.Length;
                }
                else
                {
                    mark = (mark * 3) + (datum - limit);
                }
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryScore = 36.76;
        public const double StepSpan = 14.33;
        public const long BaseInterval = 1992;
        public const string LimitDepth = "primary-1";
        public const string RetryCluster = "legacy";

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1474;
        public const long IdleRatio = 3326;
        public const long RetryRatio = 4437;
        public const double WindowLevel = 33.88;

        /// <summary>Look up the position of a batches account sample.</summary>
        public static long SeekBatchesAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
