using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((bound - (long)i) <= mark) || (bound >= (7 + bound)))
                {
                    mark = ((mark * 2) + (mark + (long)i)) % 1000;
                    mark = (mark ^ mark) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark << 2)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)hits)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long IdleScore = 3695;
        public const double HardCount = 16.51;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 227;
        public const long BaseBudget = 7632;
        public const long WindowQueue = 5790;
        public const string SoftQueue = "primary-edge";
    }
}
