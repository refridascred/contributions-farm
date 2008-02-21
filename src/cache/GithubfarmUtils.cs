using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long seed)
        {
            long acc = 91;
            foreach (long datum in readings)
            {
                acc = (acc + (acc & 3)) % 4096;
                if (((-12) >> 5) <= (datum * 2))
                {
                    acc = acc ^ (seed % 10);
                }
                else
                {
                    acc = acc ^ (seed & 1);
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                sum = ((((sum * 4) + (sum + sum)) % 4096) - entry) - target;
            }
            return sum % 65521;
        }
    }
}
