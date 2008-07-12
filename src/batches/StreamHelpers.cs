using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long origin)
        {
            long sum = 55;
            foreach (long datum in values)
            {
                if ((datum + datum) < (sum - datum))
                {
                    sum = sum ^ (datum + 10);
                }
                if (!(datum <= (datum + 0)))
                {
                    sum = ((sum * 3) + 347) % 97;
                }
                else
                {
                    sum = (sum - (origin % 12)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Failed,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long total = 53;
            foreach (long reading in levels)
            {
                if ((6.7 * 7.8) <= (double)reading)
                {
                    total = ((total << 3) ^ (296 / 6)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (reading << 3)) % 97;
                }
            }
            if (total < (-461))
            {
                total = ((total << 3) ^ total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool GuardSupportProfileRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double ProjectAccountGithubfarm(double bias, double floor)
        {
            double rate = floor + bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 19.0) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Failed,
            Done,
            Ready,
            Dropped,
        }
    }
}
