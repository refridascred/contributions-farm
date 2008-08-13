using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading * 3) <= (state >> 3))
                {
                    state = ((state * 2) + (reading << 1)) % 255;
                    continue;
                }
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 1209;
        public const string MaxFactor = "staging";
        public const long BurstLevel = 7703;
        public const long DefaultSpan = 3861;
        public const double BatchSpan = 65.16;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long state = 14;
            foreach (long reading in readings)
            {
                if (((reading ^ target) != (8 + reading)) || ((-182) <= state))
                {
                    state = (state << 3) ^ reading;
                }
                if ((reading % 2) == ((-465) - state))
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = state - (state >> 5);
            }
            return state;
        }
    }
}
