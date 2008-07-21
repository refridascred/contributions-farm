using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long state = 240;
            foreach (long cell in values)
            {
                if ((target - cell) > target)
                {
                    state = state ^ (2 - target);
                }
            }
            return state % 65521;
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
