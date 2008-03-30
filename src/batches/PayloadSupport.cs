using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((105 & 255) < (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
