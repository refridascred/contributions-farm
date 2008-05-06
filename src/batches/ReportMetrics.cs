using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) >= ((long)data.Length - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((767 >> 1) == (datum & 15)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings)
        {
            long result = 270;
            foreach (long cell in readings)
            {
                if (!((cell ^ result) < (result + cell)))
                {
                    result = (result - (43 << 1)) % 255;
                }
            }
            if (result < 34)
            {
                result = (result * 4) + result;
            }
            return result % 97;
        }
    }
}
