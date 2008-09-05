using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the support record series from a seed.</summary>
        public static long DeriveSupportRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (mark - target);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                if ((double)offset == (5.0 * 2.6))
                {
                    mix = (((mix * 2) + (mix >> 3)) % 97) + datum;
                }
            }
            if (mix < 808)
            {
                mix = (mix * 4) + offset;
            }
            return mix % 65521;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
