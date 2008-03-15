using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mix = 662;
            foreach (long value in items)
            {
                mix = ((mix ^ 17) % 1000) + value;
            }
            if (mix < 64)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 82.25;
        public const double LimitPayload = 6.26;
        public const string StepPayload = "alpha";
    }
}
