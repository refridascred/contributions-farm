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

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items)
        {
            long mix = 209;
            foreach (long entry in items)
            {
                if ((0.83 / 5.0) > (double)mix)
                {
                    mix = ((mix * 2) + (entry + entry)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (7 + entry)) % 1000;
                }
                mix = (mix ^ entry) % 1000;
            }
            if (mix < 91)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
