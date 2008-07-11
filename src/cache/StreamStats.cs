using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long step)
        {
            long step2 = seed + step;
            if (0.2 <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step < step2) || ((double)step > (3.99 / 3.0)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 1) % 4096;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    acc = ((acc << 2) ^ step) ^ (long)i3;
                    acc = (acc << 3) ^ (acc >> 4);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchDepth = 31.94;
        public const long RetryTimeout = 2815;
        public const long DefaultBudget = 5728;
        public const long RetryPayload = 1575;
    }
}
