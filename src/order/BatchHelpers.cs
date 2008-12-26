using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 5042;
        public const long StepSize = 6400;
        public const long LimitSpan = 4105;
        public const long MaxTools = 4534;
        public const double WindowTools = 78.33;

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long RankContributiBatch(long limit, long step)
        {
            long step2 = limit + step;
            if (((step & 7) <= (step % 2)) || ((limit + 692) >= (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((step ^ 55) <= (step2 - step2)) && ((step2 * 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if (((93 + step2) <= (step ^ step2)) && ((10.0 / 9.0) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
