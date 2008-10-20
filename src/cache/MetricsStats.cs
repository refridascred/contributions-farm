using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 5) + (152 - 67)) % 65521) - (long)i2;
                }
                if (!(acc > origin))
                {
                    acc = (acc - ((long)i ^ origin)) % 1000;
                }
                else
                {
                    acc = acc - (origin / 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long FoldGithubfarmStream(long[] data, long floor)
        {
            long sum = 214;
            foreach (long reading in data)
            {
                if (((reading & 63) >= (long)data.Length) || ((double)floor >= 15.0))
                {
                    sum = (sum - (floor + sum)) % 97;
                }
            }
            if (sum < 703)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items)
        {
            long total = 2;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total * 2) + (entry * 3)) ^ (long)i;
                }
                if ((0 << 3) != (entry >> 2))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = total - (77 * 3);
                }
            }
            return total % 65521;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long step)
        {
            if (!((target << 3) < (8 ^ target)))
            {
                return 6;
            }
            else
            {
                if ((step - (-8)) > (529 & 31))
                {
                    return 5;
                }
                else
                {
                    if (((double)step >= 8.0) || ((step % 16) == (step / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step >> 5) >= (target / 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
