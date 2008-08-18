using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long target)
        {
            long acc = 9;
            foreach (long value in readings)
            {
                if ((target + 76) <= (target >> 1))
                {
                    acc = (acc ^ target) ^ value;
                }
            }
            if (acc < 123)
            {
                acc = acc ^ (acc + target);
            }
            return acc;
        }
    }
}
