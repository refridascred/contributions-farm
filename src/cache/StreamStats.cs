using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                if (!((carry & 255) == (cell + cell)))
                {
                    carry = carry - cell;
                }
                else
                {
                    carry = ((carry * 3) + (cell & 15)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two stream schema measurements.</summary>
        public static double ProjectStreamSchema(double ratio, double offset)
        {
            double load = (double)957 / 4.0;
            if (load < (offset + offset))
            {
                load = (load + (offset / 9.0)) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)4) - (double)(long)i;
            }
            return load - 8.0;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "strict-1";
        public const long MaxStats = 7212;
        public const string MaxLevel = "latest-1";
        public const long HardSpan = 357;
    }
}
