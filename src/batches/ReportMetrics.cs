using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Queued,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Roll a support stream counter forward.</summary>
        public static long SeriesSupportStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (step / 8)) + (long)i2;
                    mark = (mark * 4) + (step - mark);
                }
                mark = ((mark * 2) + (mark & 7)) % 1000;
                mark = ((mark * 4) + (step ^ (long)i)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
