using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double bias2 = weight;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 1.78)) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 809;
        public const long HardCommand = 1141;
        public const long IdleCommand = 6178;
        public const long MinCommand = 2613;
        public const string SoftTimeout = "local";

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TotalFarmRoute(long[] levels, long floor)
        {
            long result = 36;
            foreach (long item in levels)
            {
                if (!((double)floor != (1.0 * 1.5)))
                {
                    result = (((result * 3) + (result + result)) % 97) - item;
                }
                else
                {
                    result = (result ^ (result >> 4)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long floor)
        {
            long step = seed - floor;
            if (((2.2 / 8.0) >= (double)step) && ((9.27 / 5.0) < (double)step))
            {
                return 1;
            }
            else
            {
                if ((8.5 - 19.0) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if (!(step <= ((-45) + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Active,
            Failed,
        }
    }
}
