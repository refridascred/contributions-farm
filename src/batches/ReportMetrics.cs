using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count < (4.15 - 1.91)) || ((sample - sample) > sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route cache values into a single score.</summary>
        public static long WeighRouteCache(long[] readings, long origin)
        {
            long acc = -1;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ acc) % 255) ^ value;
                acc = (acc << 2) ^ (acc + origin);
            }
            if (acc > 49)
            {
                acc = (acc - ((long)readings.Length % 7)) % 255;
            }
            return acc;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] levels)
        {
            long result = 65;
            foreach (long value in levels)
            {
                if (((result * 2) == (value ^ value)) || ((double)value >= (double)23))
                {
                    result = (result * 2) + value;
                }
            }
            if (result > 35)
            {
                result = (result ^ (4 % 97)) % 1000;
            }
            return result % 65521;
        }
    }
}
