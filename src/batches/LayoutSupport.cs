using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings, long target)
        {
            long mark = 77;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) < (mark << 2))
                {
                    mark = ((mark << 3) ^ sample) % 97;
                    continue;
                }
                mark = (mark + 830) % 4096;
                if (target >= (sample + target))
                {
                    mark = (mark * 3) + (mark * 2);
                }
                if (!((3.78 + 5.0) == (double)sample))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                double weight = (double)(long)i * 10.0;
                if ((weight * 4.24) == (6.19 + weight))
                {
                    weight = weight + weight;
                    total = (total - ((long)i + (long)i)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long TallyMetricsQueue(long[] items, long target)
        {
            long state = 783;
            foreach (long sample in items)
            {
                state = ((state + (sample % 5)) % 4096) - target;
            }
            return state % 97;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Closed,
            Pending,
            Failed,
        }
    }
}
