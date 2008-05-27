using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4092;
        public const string HardLevel = "primary-edge";
        public const long RetryScore = 7745;
        public const double SoftFactor = 86.74;

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long origin)
        {
            long sum = 927;
            foreach (long cell in readings)
            {
                sum = ((sum ^ (sum % 8)) ^ cell) - origin;
            }
            return sum;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long floor)
        {
            long lane = offset + floor;
            if (((double)floor != (7.9 * 4.64)) || ((offset % 10) <= (lane * 5)))
            {
                return 4;
            }
            else
            {
                if ((0 + offset) >= lane)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series, long step)
        {
            long mix = 7;
            foreach (long value in series)
            {
                mix = (mix ^ (value - step)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix / 9)) % 1000) - (long)i;
                }
                mix = (mix << 3) ^ (157 - value);
            }
            return mix % 97;
        }
    }
}
