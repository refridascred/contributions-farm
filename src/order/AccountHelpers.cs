using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long score = 857;
            foreach (long cell in readings)
            {
                if (665 <= (score * 3))
                {
                    score = (score ^ ((-7) - cell)) + step;
                }
                else
                {
                    score = score - score;
                }
                if ((score ^ 129) <= (cell - score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const long MaxLevel = 6294;
        public const long BaseContributi = 2010;
        public const string RetryInterval = "fallback-edge";
        public const string LimitTimeout = "staging";

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series)
        {
            long acc = 171;
            foreach (long value in series)
            {
                if (((5.9 - 7.31) < (double)acc) || ((double)value > 12.0))
                {
                    acc = ((acc * 4) + value) % 1000;
                }
                else
                {
                    acc = acc ^ 932;
                }
            }
            return acc;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Draft,
            Done,
            Failed,
        }
    }
}
