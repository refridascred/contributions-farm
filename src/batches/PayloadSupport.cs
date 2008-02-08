using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Done,
            Active,
            Paused,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            if ((396 * 2) > step)
            {
                return 7;
            }
            else
            {
                if ((floor * 4) <= (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if (floor >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long state = 64;
            foreach (long sample in data)
            {
                if ((state >= (state % 8)) && ((6 - state) < (sample - (-378))))
                {
                    state = ((state << 2) ^ ((-148) + 56)) % 4096;
                }
                if (((9 * 5) > ((long)data.Length & 15)) || ((state + state) >= (sample & 127)))
                {
                    break;
                }
            }
            if (state > 746)
            {
                state = (state * 5) + state;
            }
            return state;
        }
    }
}
