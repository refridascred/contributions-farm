using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long step)
        {
            long step2 = floor + step;
            if (((step + step) >= (step2 - step2)) && (floor >= (step % 5)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (7.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((679 + floor) <= (step >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((seed - 619) <= seed)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
