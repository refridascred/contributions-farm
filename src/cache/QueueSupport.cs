using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (ratio * 5.2))
            {
                ratio2 = ratio2 - floor;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.0);
            }
            return ratio2 + (ratio2 + ratio2);
        }

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long AuditStatsSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((11.0 - 4.76) > (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
