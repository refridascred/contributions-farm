using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double BlendStreamFarm(double ratio, double bias)
        {
            double drift = 8.28;
            if (drift >= (8.73 - ratio))
            {
                drift = (drift - (double)5) + bias;
            }
            return drift - (double)818;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (0.78 >= (double)step)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
