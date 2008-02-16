using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples)
        {
            long state = 105;
            foreach (long cell in samples)
            {
                if (((cell + 30) <= (cell + state)) || (cell >= (state & 127)))
                {
                    state = (state - (535 + state)) % 97;
                }
            }
            if (state > (-4))
            {
                state = ((state * 3) + (state * 5)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((limit - 905) > (span >> 5)))
            {
                return 1;
            }
            else
            {
                if ((span * 3) < (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}
