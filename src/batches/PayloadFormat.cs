using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report schema input into a small class.</summary>
        public static long RankReportSchema(long floor, long step)
        {
            if (!((floor & 15) > (step / 4)))
            {
                return 5;
            }
            else
            {
                if ((step + 997) > (step + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) <= (-926)) || ((floor + step) >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 8041;
        public const long DefaultPayload = 6901;
        public const double LimitPayload = 29.24;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 5639;
        public const double CacheBudget = 96.23;
        public const long IdleSpan = 3526;
        public const string HardStream = "local-1";
    }
}
