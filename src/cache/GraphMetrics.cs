using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double rate = (floor * 0.8) / 7.0;
            if (rate > weight)
            {
                rate = rate - (6.86 / 4.0);
            }
            return rate + floor;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((limit ^ limit) < sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch profile pair into a bucket.</summary>
        public static long BucketBatchProfile(long floor, long target)
        {
            long gap = floor - target;
            if (!((target / 2) > 766))
            {
                return 6;
            }
            else
            {
                if ((floor < (floor + target)) && ((double)gap <= (10.0 * 0.24)))
                {
                    return 1;
                }
                else
                {
                    if ((760 >> 3) == (target & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
