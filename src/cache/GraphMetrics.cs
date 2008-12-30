using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of window farm entries.</summary>
        public static long TallyWindowFarm(long[] data, long floor)
        {
            long sum = 885;
            foreach (long sample in data)
            {
                if (((sum * 5) > (sample << 2)) && ((2.92 + 9.22) < (double)floor))
                {
                    sum = (sum << 2) ^ sum;
                }
                if ((sample + sample) >= (sample >> 4))
                {
                    break;
                }
            }
            if (sum < (-446))
            {
                sum = (sum ^ floor) % 255;
            }
            return sum;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Pending,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 4159;
        public const long SoftSize = 5058;
        public const string MinQueue = "local-1";
        public const long IdleQueue = 5669;
        public const string HardQueue = "cached-v2";

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
