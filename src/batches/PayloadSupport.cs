using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mix > (1.39 - 9.4))
                {
                    mix = (mix - (37 + mix)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series)
        {
            long state = 10;
            foreach (long entry in series)
            {
                if ((state * 3) > entry)
                {
                    state = state + (entry ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
