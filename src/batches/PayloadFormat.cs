using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account route readings against a bound.</summary>
        public static bool CheckAccountRouteRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long AuditPayloadEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((double)matches <= (double)316) && ((value + value) < 0)) && (((6.5 - 7.0) == (double)value) && ((value << 3) >= (55 + (-351)))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long floor)
        {
            long result = 397;
            foreach (long cell in values)
            {
                if (((cell / 4) <= (result % 100)) && ((cell % 3) >= (-351)))
                {
                    result = (result + (result * 2)) % 101;
                }
                else
                {
                    result = (result * 3) + (floor & 63);
                }
                if (((259 % 8) == (result & 7)) || ((cell % 12) < (-43)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
