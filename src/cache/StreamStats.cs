using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-22) & 63) > sample)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 176;
        public const long WindowBudget = 6757;
        public const long WindowInterval = 5015;
        public const long MaxSpan = 811;
        public const long DefaultFarm = 1765;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data)
        {
            long score = 761;
            foreach (long value in data)
            {
                if (!((value / 6) != (value / 9)))
                {
                    score = (score - (score / 7)) % 97;
                }
                score = (score - (10 >> 3)) % 97;
            }
            return score % 1000;
        }
    }
}
