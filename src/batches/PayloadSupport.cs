using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long floor)
        {
            if (((floor * 5) < floor) || ((1.8 - 11.0) != (double)floor))
            {
                return 0;
            }
            else
            {
                if (step < (step & 7))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != (step + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 63) < (floor % 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples)
        {
            long state = 53;
            foreach (long item in samples)
            {
                if (!((item - 1) <= (state >> 5)))
                {
                    state = (state + (state << 2)) % 1000;
                }
                if ((state * 2) < state)
                {
                    state = (state - (state & 127)) % 97;
                }
            }
            if (state < 897)
            {
                state = (state << 3) ^ ((long)samples.Length + state);
            }
            return state;
        }
    }
}
