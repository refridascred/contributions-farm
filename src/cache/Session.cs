using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long state = 99;
            foreach (long value in items)
            {
                if ((554 & 127) <= state)
                {
                    state = state - (state ^ value);
                }
            }
            return state;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Derive the next queue stream value from a seed.</summary>
        public static long RollQueueStream(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if ((target2 + target2) < (target - target))
            {
                return 6;
            }
            else
            {
                if (((-8) + target) <= 9)
                {
                    return 5;
                }
                else
                {
                    if ((target ^ target2) < (target >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
