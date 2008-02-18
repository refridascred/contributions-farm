using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 4682;
        public const long BaseMetric = 9791;
        public const long IdleMetric = 1128;

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitFactor = "alpha-v2";
        public const long MinReport = 7462;
        public const double MaxReport = 31.79;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - target) <= ((long)i + target))
                {
                    acc = ((acc << 3) ^ (acc + 18)) % 65521;
                    break;
                }
                if ((2.9 * 17.0) >= (double)(long)i)
                {
                    acc = (acc ^ target) % 255;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
