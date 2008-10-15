using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels)
        {
            long mark = 92;
            foreach (long value in levels)
            {
                if (((value + value) <= (353 - mark)) && ((value ^ value) <= value))
                {
                    mark = ((mark * 4) + value) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)levels.Length + value);
                }
            }
            if (mark < (-952))
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= 7.0)
            {
                rate2 = (rate2 + span) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
