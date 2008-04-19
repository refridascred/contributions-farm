using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long acc = 235;
            foreach (long value in levels)
            {
                if ((value + seed) > (acc / 9))
                {
                    acc = ((acc << 3) ^ (acc % 64)) % 97;
                    acc = (acc ^ acc) % 97;
                }
                else
                {
                    acc = (acc << 2) ^ 37;
                }
                if ((1.32 * 7.1) >= (double)value)
                {
                    acc = (acc ^ (value + acc)) % 1000;
                }
                if ((5.71 + 7.16) != (double)value)
                {
                    acc = acc + (value << 1);
                }
                if (acc < (value - (-167)))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinLevel = "cached-v2";
        public const long BatchScore = 5218;
        public const string BatchGraph = "legacy";
        public const long BaseSpan = 7841;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double gain = (1.06 - bias) - bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias + span)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
