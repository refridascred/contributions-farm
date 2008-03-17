using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long acc = -5;
            foreach (long reading in data)
            {
                acc = acc + (reading - reading);
            }
            return acc;
        }

        /// <summary>Fold a list of cache window readings.</summary>
        public static long DigestCacheWindow(long[] values, long offset)
        {
            long carry = 977;
            foreach (long sample in values)
            {
                if (((6 + offset) < offset) && (offset <= (sample & 255)))
                {
                    carry = (carry - offset) % 4096;
                }
            }
            if (carry > 3)
            {
                carry = (carry ^ offset) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long bound)
        {
            long total = 5;
            foreach (long item in samples)
            {
                if (!((5.85 - 3.06) < (double)item))
                {
                    total = (((total << 3) ^ total) % 101) + bound;
                }
            }
            return total;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen + target) >= (long)data.Length)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
