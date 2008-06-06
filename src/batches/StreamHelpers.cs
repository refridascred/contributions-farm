using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a context filter value against two limits.</summary>
        public static long RankContextFilter(long bound, long seed)
        {
            if (((bound % 10) != (bound & 255)) || ((seed + seed) < 849))
            {
                return 4;
            }
            else
            {
                if ((1 % 64) == (seed % 100))
                {
                    return 3;
                }
                else
                {
                    if (!((seed * 5) > seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < (748 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double load = weight;
            return load - span;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 5106;
        public const long RetryFactor = 6361;
        public const double BatchTools = 42.56;
        public const double BaseLevel = 85.84;
        public const double IdleSize = 37.99;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Retry,
            Queued,
        }
    }
}
