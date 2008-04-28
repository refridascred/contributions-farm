using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate record layout readings against a bound.</summary>
        public static bool ValidateRecordLayoutLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Retry,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            New,
            Active,
            Closed,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((5 << 3) < (long)i))
                {
                    mix = ((mix * 4) + (long)i) % 65521;
                }
                if ((double)seed > (2.0 / 4.0))
                {
                    mix = mix ^ seed;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
