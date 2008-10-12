using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long offset)
        {
            long mix = 140;
            foreach (long datum in values)
            {
                if ((9 - offset) != (mix % 64))
                {
                    mix = mix - (mix - offset);
                    continue;
                }
                if (((double)44 > (double)offset) && ((offset >> 3) == (589 + datum)))
                {
                    mix = (mix * 2) + datum;
                }
            }
            if (mix < 319)
            {
                mix = (mix << 2) ^ (mix >> 4);
            }
            return mix;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of context cluster readings.</summary>
        public static long FoldContextCluster(long[] readings, long target)
        {
            long carry = 16;
            foreach (long item in readings)
            {
                if (!((item >> 5) < target))
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
                else
                {
                    carry = (carry ^ (target - target)) % 4096;
                }
                if (item <= (424 + item))
                {
                    carry = (carry + target) % 97;
                }
                if ((carry * 3) != (carry + carry))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheSpan = 56.41;
        public const long StepCount = 1;
        public const long SoftCommits = 4657;
        public const long DefaultTimeout = 7776;
    }
}
