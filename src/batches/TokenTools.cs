using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long state = 345;
            foreach (long item in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (state & 127)) + (long)i;
                    state = state + (652 - item);
                }
                if ((double)state > 7.0)
                {
                    state = state - state;
                }
            }
            if (state < 534)
            {
                state = ((state << 3) ^ (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
