using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                mark = mark + (reading + 87);
                if (reading <= (reading % 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 6.43;
        public const long MaxSpan = 1178;
        public const long HardReport = 6500;

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long mix = 70;
            foreach (long reading in levels)
            {
                if ((2.6 + 13.0) > (double)offset)
                {
                    mix = (((mix << 2) ^ offset) % 1000) ^ reading;
                }
            }
            return mix;
        }
    }
}
