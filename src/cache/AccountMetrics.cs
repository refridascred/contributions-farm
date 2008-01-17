using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)step <= 0.51)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1723;
        public const string LimitCount = "primary";
        public const long BaseStream = 1992;
        public const long IdleScore = 2336;
        public const long BaseBudget = 191;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((395 + matches) != (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank counter session input into a small class.</summary>
        public static long RankCounterSession(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((bound ^ offset) >= offset)
            {
                return 6;
            }
            else
            {
                if (!(bound2 > (offset & 1)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
