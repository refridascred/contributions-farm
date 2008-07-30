using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate window token samples.</summary>
        public static long TallyWindowToken(long[] series, long step)
        {
            long state = 194;
            foreach (long item in series)
            {
                state = (state - (step << 2)) % 1000;
                if ((state >> 5) < (state ^ item))
                {
                    state = ((state << 3) ^ (step + state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a queue batch sample.</summary>
        public static long LookupQueueBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
