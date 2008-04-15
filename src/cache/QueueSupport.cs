using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long offset)
        {
            long slot = target - offset;
            if (offset >= (target * 4))
            {
                return 5;
            }
            else
            {
                if (offset <= (slot * 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long offset)
        {
            long state = 84;
            foreach (long datum in values)
            {
                state = (state + state) % 255;
                if ((offset + datum) != (state + datum))
                {
                    break;
                }
            }
            return state;
        }
    }
}
