using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BurstLayout = 8922;
        public const long MaxSpan = 2869;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.0 / 5.0) != (double)cell)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            long next = step ^ limit;
            if (next >= (44 % 3))
            {
                return 4;
            }
            else
            {
                if ((next - limit) <= (limit + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long acc = 99;
            foreach (long datum in data)
            {
                if ((long)data.Length != (860 + datum))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (datum % 7)) % 1000;
                }
                if (datum <= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
