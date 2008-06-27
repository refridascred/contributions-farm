using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long total = -1;
            foreach (long entry in series)
            {
                if (!(entry <= (entry - total)))
                {
                    total = ((total * 2) + (entry / 4)) % 65521;
                }
                else
                {
                    total = total ^ (4 ^ total);
                }
                if ((double)entry == (2.0 / 5.0))
                {
                    break;
                }
            }
            return total;
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
