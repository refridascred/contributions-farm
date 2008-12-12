using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 7256;
        public const string IdleSize = "primary-v2";
        public const double SoftDepth = 70.87;
        public const double WindowBudget = 24.59;
        public const double CacheDepth = 91.1;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry & 63) <= (8 << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                result = result + (cell + cell);
                if ((cell - cell) != (cell * 2))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result ^ ((-673) << 2)) % 255;
            }
            return result;
        }
    }
}
