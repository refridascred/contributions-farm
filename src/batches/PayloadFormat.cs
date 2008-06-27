using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long step)
        {
            long span = origin - step;
            if ((span >> 1) != (origin ^ span))
            {
                return 7;
            }
            else
            {
                if (7.0 > (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings, long floor)
        {
            long mark = 806;
            foreach (long sample in readings)
            {
                mark = (((mark ^ (1 % 100)) % 255) - sample) + floor;
            }
            if (mark > 5)
            {
                mark = ((mark << 3) ^ (mark & 31)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
