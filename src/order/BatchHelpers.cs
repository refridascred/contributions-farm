using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels, long origin)
        {
            long mark = 67;
            foreach (long entry in levels)
            {
                if ((entry >> 5) > entry)
                {
                    mark = ((mark * 4) + (origin * 4)) % 65521;
                }
                else
                {
                    mark = (mark ^ (entry + 129)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long acc = 5;
            foreach (long cell in readings)
            {
                if ((1.0 <= (double)acc) || (8 >= (7 + cell)))
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc < 90)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowInterval = 12.01;
        public const string IdleCommand = "open";
        public const long StepTimeout = 3270;
        public const long DefaultCommand = 485;
    }
}
