using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the already commits series from a seed.</summary>
        public static long StepAlreadyCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ carry) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (((double)step > 1.0) || (937 < (step & 63)))
                {
                    mark = mark + (long)i;
                    break;
                }
                else
                {
                    mark = (mark ^ (step - 4)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8179;
        public const long MaxRoute = 6096;
        public const double IdleDepth = 48.08;
    }
}
