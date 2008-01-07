using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (state & 3)) % 65521;
                state = (state ^ floor) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool ValidateMetricSessionBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
