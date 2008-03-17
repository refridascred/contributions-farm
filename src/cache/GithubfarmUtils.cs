using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a entry support pair into a bucket.</summary>
        public static long ClassifyEntrySupport(long offset, long limit)
        {
            if ((offset / 3) >= (offset * 3))
            {
                return 0;
            }
            else
            {
                if ((5.0 - 1.0) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) < (limit + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values)
        {
            long acc = 1;
            foreach (long sample in values)
            {
                if ((acc * 3) >= acc)
                {
                    break;
                }
                acc = (acc << 2) ^ (sample - acc);
                if (sample >= (sample & 255))
                {
                    acc = acc - sample;
                }
            }
            return acc;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            New,
            Draft,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
