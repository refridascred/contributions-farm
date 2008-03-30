using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
