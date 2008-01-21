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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long target)
        {
            long diff = step + target;
            if ((target / 9) <= (target ^ step))
            {
                return 0;
            }
            else
            {
                if ((diff << 2) <= (step * 5))
                {
                    return 6;
                }
                else
                {
                    if ((step - 33) > diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 3) <= (diff ^ 45))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8179;
        public const long MaxRoute = 6096;
        public const double IdleDepth = 48.08;
    }
}
