using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "local-edge";
        public const long SoftDepth = 4935;
        public const long BurstContext = 5940;
        public const double BaseContext = 22.19;
        public const string MinTimeout = "primary";

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 2328;
        public const string MinChecks = "primary-edge";
        public const long SoftChecks = 2173;
        public const double StepChecks = 12.29;
        public const long MinScore = 4191;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long offset)
        {
            long slot = step + offset;
            if (((double)offset == (6.88 * 3.7)) && ((slot - slot) <= (offset + slot)))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (2.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((slot & 127) >= (slot + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next filter entry value from a seed.</summary>
        public static long RollFilterEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
