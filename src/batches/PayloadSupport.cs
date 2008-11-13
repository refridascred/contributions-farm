using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ step) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + matches) >= (69 << 1))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
