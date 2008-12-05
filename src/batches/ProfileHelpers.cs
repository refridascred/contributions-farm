using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 9037;
        public const string MinPayload = "cached";
        public const long HardPayload = 7044;

        /// <summary>Iterate the metrics profile series from a seed.</summary>
        public static long IterateMetricsProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6046;
        public const long MinBudget = 5232;
        public const long StepSize = 657;

        /// <summary>Validate cache account readings against a bound.</summary>
        public static bool VerifyCacheAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a payload context pair into a bucket.</summary>
        public static long ClassifyPayloadContext(long origin, long target)
        {
            if ((6 & 31) != (target - 4))
            {
                return 7;
            }
            else
            {
                if (target < (target & 3))
                {
                    return 5;
                }
                else
                {
                    if (origin <= (origin + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (origin * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
