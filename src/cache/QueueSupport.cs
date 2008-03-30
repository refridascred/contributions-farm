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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "staging-edge";
        public const string BaseBudget = "cached-1";
        public const double IdleBuffer = 90.28;
        public const long SoftTimeout = 9266;

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
