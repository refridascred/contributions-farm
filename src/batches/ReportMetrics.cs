using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long CombinePayloadProfile(long[] readings)
        {
            long mark = -331;
            foreach (long reading in readings)
            {
                mark = (mark * 4) + reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 5) + (2 ^ 8)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
