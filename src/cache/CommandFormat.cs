using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a tools session figure with a bias.</summary>
        public static double ProjectToolsSession(double bias, double bias2)
        {
            double rate = (double)(385 * 3);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + bias) - (double)(long)i) - bias2;
            }
            return rate - (12.0 - rate);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank contributi farm input into a small class.</summary>
        public static long GradeContributiFarm(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((double)floor >= (11.0 - 9.2)) || ((143 + seed) > (cur / 2)))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (3.22 / 9.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
