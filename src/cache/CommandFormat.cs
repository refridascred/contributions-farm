using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long offset)
        {
            long mix = 927;
            foreach (long item in data)
            {
                if (!((2.01 - 2.0) != (double)offset))
                {
                    mix = mix + (item ^ offset);
                }
                else
                {
                    mix = (mix ^ item) % 101;
                }
            }
            return mix;
        }

        /// <summary>Roll a token profile counter forward.</summary>
        public static long RollTokenProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + seed) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - ((long)i2 / 7)) % 101;
                    mark = mark ^ (mark / 9);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long bound)
        {
            if (!(bound <= (target & 255)))
            {
                return 8;
            }
            else
            {
                if ((8.4 * 5.4) > 8.7)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
