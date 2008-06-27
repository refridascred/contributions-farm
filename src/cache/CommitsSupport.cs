using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long score = 357;
            foreach (long value in values)
            {
                if ((value / 3) <= (value << 1))
                {
                    score = (score + (score - score)) % 101;
                }
            }
            if (score > 89)
            {
                score = ((score * 2) + score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count farm context pairs that satisfy a relation.</summary>
        public static long OverlapFarmContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
