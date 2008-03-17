using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long step)
        {
            long mix = 8;
            foreach (long reading in levels)
            {
                if (step <= (939 >> 2))
                {
                    mix = mix + (reading * 5);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
