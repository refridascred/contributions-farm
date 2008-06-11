using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double mean = (double)(0 + 0);
            if (mean >= scale)
            {
                mean = mean - floor;
            }
            return mean - scale;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long CombineSessionWindow(long[] readings, long target)
        {
            long anchor = 85;
            foreach (long reading in readings)
            {
                if ((target & 127) >= anchor)
                {
                    anchor = anchor - reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
