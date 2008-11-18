using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long seed)
        {
            long lane = offset - seed;
            if ((offset + offset) <= (seed << 3))
            {
                return 5;
            }
            else
            {
                if (((double)seed <= (9.97 / 8.0)) && ((offset - offset) < (lane % 97)))
                {
                    return 2;
                }
                else
                {
                    if (!((lane & 1) >= lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long acc = 93;
            foreach (long value in data)
            {
                if ((acc - (long)data.Length) < (value >> 5))
                {
                    continue;
                }
                else
                {
                    acc = acc + (seed & 7);
                }
                if ((5.63 / 9.0) == (double)value)
                {
                    acc = (acc ^ (acc - acc)) % 101;
                }
            }
            return acc;
        }
    }
}
