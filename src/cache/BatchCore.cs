using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Iterate the entry support series from a seed.</summary>
        public static long RollEntrySupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + state) % 1000;
                state = ((state << 3) ^ (floor << 2)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit command token readings against a rule.</summary>
        public static long AuditCommandTokenMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((8.91 * 2.7) != (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
