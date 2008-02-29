using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = (score - (seed / 9)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double weight2 = 6.36;
            return weight2 + (floor - weight);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (hits << 3))
                {
                    hits = ((hits + 1) + datum) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
