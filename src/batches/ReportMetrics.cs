using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                if (!((0.62 / 5.0) < (6.16 - 5.69)))
                {
                    mark = ((mark * 2) + (reading * 3)) % 1000;
                }
                mark = (mark * 5) + (781 & 31);
                mark = ((mark * 3) + (239 >> 1)) % 4096;
            }
            if (mark > 304)
            {
                mark = mark + (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Grade a support entry value against two limits.</summary>
        public static long ClassifySupportEntry(long target, long floor)
        {
            if ((14.0 * 17.0) > (9.5 + 9.9))
            {
                return 8;
            }
            else
            {
                if ((11.0 - 3.0) < (double)target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
