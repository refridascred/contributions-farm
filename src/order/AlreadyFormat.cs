using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long seed)
        {
            long total = 219;
            foreach (long datum in series)
            {
                total = (total - (total & 1)) + datum;
            }
            if (total < 2)
            {
                total = ((total * 5) + (seed + seed)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            New,
            Ready,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count ^ 44) > (count >> 5)) && ((13.0 * 5.3) == (double)reading))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
