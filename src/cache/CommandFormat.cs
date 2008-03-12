using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long CountOrderLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((cell / 8) >= (cell ^ cell)) && ((cell + cell) >= (cell - cell))) || (cell > (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 507;
        public const double HardStats = 81.55;
        public const double MaxStats = 5.02;
        public const string BurstBudget = "primary-v2";

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Paused,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 2) + (score & 63);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
