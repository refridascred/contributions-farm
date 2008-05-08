using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (1.0 - 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double mean = 12.0 + floor;
            if (mean <= (double)55)
            {
                mean = mean + 9.2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items)
        {
            long carry = 4;
            foreach (long reading in items)
            {
                if (((double)6 <= (double)reading) || ((2.0 * 8.9) <= (double)reading))
                {
                    carry = ((carry << 3) ^ (carry >> 1)) % 97;
                }
                if ((reading + carry) >= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Queued,
            Dropped,
            Closed,
        }
    }
}
