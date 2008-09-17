using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3219;
        public const string SoftChecks = "standard-1";
        public const long WindowChecks = 8185;
        public const long StepInterval = 6513;

        /// <summary>Validate metric schema readings against a bound.</summary>
        public static bool ValidateMetricSchemaLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache stream counter forward.</summary>
        public static long SeriesCacheStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
