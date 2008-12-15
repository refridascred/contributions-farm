using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum << 2) ^ (sum + sum)) % 255;
                if (sum > (origin + origin))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading / 7) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Failed,
        }
    }
}
