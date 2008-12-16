using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Dropped,
            New,
            Active,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values)
        {
            long mix = 13;
            foreach (long item in values)
            {
                if ((item + item) <= item)
                {
                    mix = (mix ^ (682 % 2)) % 65521;
                }
            }
            if (mix > 550)
            {
                mix = ((mix * 5) + (100 + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
