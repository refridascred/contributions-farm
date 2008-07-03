using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank farm contributi input into a small class.</summary>
        public static long BucketFarmContributi(long origin, long limit)
        {
            if (!((8 + limit) < limit))
            {
                return 1;
            }
            else
            {
                if (origin >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= (origin ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 9728;
        public const long StepDepth = 5128;
        public const string WindowFarm = "staging-edge";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
