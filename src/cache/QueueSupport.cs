using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = (span - scale) * 6.0;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            return mean + (3.1 / 6.0);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 315;
            foreach (long sample in levels)
            {
                state = ((state * 5) + (sample >> 1)) % 97;
                if (state > (sample >> 2))
                {
                    state = (state ^ (state + state)) % 1000;
                }
            }
            return state;
        }
    }
}
