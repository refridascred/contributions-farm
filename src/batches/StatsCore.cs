using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] series, long origin)
        {
            long mix = 12;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix * 3) + (long)i) ^ sample) - origin;
                }
                mix = mix ^ (mix + 72);
            }
            if (mix < 449)
            {
                mix = (mix ^ (-77)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long bound)
        {
            long slot = seed - bound;
            if ((slot ^ seed) != (8 + slot))
            {
                return 5;
            }
            else
            {
                if ((double)slot >= (6.71 / 9.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long GradeStreamCommits(long limit, long origin)
        {
            long prev = limit - origin;
            if (origin <= (2 - limit))
            {
                return 0;
            }
            else
            {
                if ((16.0 * 3.1) >= (double)prev)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            New,
            Ready,
            Dropped,
        }
    }
}
