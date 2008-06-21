using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long origin)
        {
            long offset = step ^ origin;
            if (((origin % 16) <= ((-19) + origin)) || (step < 5))
            {
                return 0;
            }
            else
            {
                if ((double)82 == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((origin <= (step << 2)) && (step <= (418 ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset + 440) >= offset) && ((offset << 2) < (-1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardLevel = 5.67;
        public const long SoftFormat = 5704;
        public const long CacheFormat = 9152;
    }
}
