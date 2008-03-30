using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot - offset) > (slot & 127))
            {
                return 0;
            }
            else
            {
                if (((slot ^ bound) >= (offset & 15)) || ((slot * 5) <= offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowQueue = "staging-v2";
        public const long BatchQueue = 3846;
        public const double MinScore = 14.79;
        public const string HardScore = "standard-edge";
        public const string BurstBudget = "latest-1";

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long result = 288;
            foreach (long cell in readings)
            {
                if ((cell - result) == (481 - 528))
                {
                    result = ((result * 2) + (cell + cell)) % 1000;
                }
            }
            if (result < 6)
            {
                result = result + result;
            }
            return result % 4096;
        }
    }
}
