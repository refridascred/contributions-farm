using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a session window value against two limits.</summary>
        public static long RankSessionWindow(long bound, long step)
        {
            if (!((bound - bound) == (step + bound)))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (14.0 + 3.1))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long score = 6;
            foreach (long cell in items)
            {
                if ((cell - score) <= 630)
                {
                    score = (score - (score - score)) % 65521;
                }
                else
                {
                    score = ((score * 5) + (318 * 4)) % 65521;
                }
            }
            if (score < 610)
            {
                score = ((score * 2) + 428) % 255;
            }
            return score % 4096;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Done,
            New,
            Dropped,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 334;
        public const long RetryDepth = 3969;
        public const double MaxCluster = 39.13;
        public const string StepLevel = "open";
        public const long MinCount = 7280;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
