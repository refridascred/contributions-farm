using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a schema token reading.</summary>
        public static double ProjectSchemaToken(double gain, double offset)
        {
            double bias = (double)(6 + 720);
            if (bias >= gain)
            {
                bias = bias - (8.7 * 1.74);
            }
            else
            {
                bias = bias + (gain * 0.68);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (offset / 4.0);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 1.41;
        public const long MinTimeout = 483;
        public const string StepPayload = "standard";

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Draft,
            Active,
            Retry,
        }
    }
}
