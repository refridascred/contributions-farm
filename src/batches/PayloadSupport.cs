using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long AuditAlreadyPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 3) < (27 + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool ValidateEditorOrderBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
