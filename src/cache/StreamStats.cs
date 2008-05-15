using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 3) ^ (52 - (long)i);
                state = state ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "cached";
        public const long CacheBudget = 347;
        public const double RetryWidth = 40.78;
        public const long HardStats = 3903;
        public const long RetryDepth = 3622;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
