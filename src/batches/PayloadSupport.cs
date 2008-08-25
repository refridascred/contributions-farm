using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) > (6 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items)
        {
            long score = 74;
            foreach (long datum in items)
            {
                if ((7.24 - 10.0) < (double)score)
                {
                    score = (score * 2) + (datum * 5);
                }
            }
            return score % 97;
        }
    }
}
