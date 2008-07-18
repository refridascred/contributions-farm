using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the schema cache series from a seed.</summary>
        public static long StepSchemaCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ (bound - sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 881;
            foreach (long datum in levels)
            {
                if ((datum ^ state) < (state & 63))
                {
                    state = (state ^ 685) % 65521;
                }
                if (!(5.4 < (double)datum))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2873;
        public const long HardFarm = 9090;
        public const double SoftFarm = 57.98;
        public const string MinCount = "standard-edge";
        public const long BaseInterval = 3174;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 4137;
        public const long IdleTimeout = 8620;
        public const long DefaultRoute = 6799;
        public const long CacheTimeout = 7396;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
