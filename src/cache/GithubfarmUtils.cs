using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long acc = 69;
            foreach (long value in samples)
            {
                if ((8.94 - 10.0) <= (double)acc)
                {
                    acc = ((acc << 2) ^ (value << 2)) % 65521;
                    continue;
                }
                else
                {
                    acc = ((acc * 4) + (value - value)) % 1000;
                }
                if (!(value < (acc * 3)))
                {
                    acc = (acc + (value ^ value)) % 4096;
                }
            }
            return acc;
        }
    }
}
