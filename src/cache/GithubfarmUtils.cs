using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value + value) == (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-20))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean + (mean * 4.38);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits > (397 - hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
