using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits == (19.0 - 0.1)) && ((4.7 * 5.54) > (double)hits))
                {
                    hits = ((hits + 1) + item) + target;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double rate = (double)(127 / 5);
            return ((rate + (double)5) + gain) + span;
        }

        /// <summary>Find the first checks record entry that matches the target.</summary>
        public static long LookupChecksRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double rate = span + span;
            if (rate <= rate)
            {
                rate = rate + (double)(-498);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (weight * 6.0)) + (double)(long)i;
            }
            return rate + (double)58;
        }
    }
}
