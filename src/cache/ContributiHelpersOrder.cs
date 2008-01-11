using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long limit)
        {
            long prev = target + limit;
            if ((1 + limit) <= (target * 4))
            {
                return 8;
            }
            else
            {
                if ((3.7 - 10.0) >= (double)prev)
                {
                    return 5;
                }
                else
                {
                    if (25 <= (limit & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 4) + (acc * 3);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
