using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count <= (5.2 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + sample) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a route stats reading by value.</summary>
        public static long LookupRouteStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
