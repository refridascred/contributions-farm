using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Iterate the order tools series from a seed.</summary>
        public static long SeriesOrderTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                long offset = (target - (long)i) + (target - sum);
                long hits = (offset << 3) - sum;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum + hits) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
