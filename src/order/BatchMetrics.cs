using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((total >> 5) == (total + (long)i))
                {
                    total = (total - offset) % 97;
                    break;
                }
                else
                {
                    total = total + (total / 2);
                    total = total ^ (total + 2);
                }
                if ((total - offset) <= (long)i)
                {
                    total = (total ^ (long)i) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long sum = 606;
            foreach (long entry in samples)
            {
                sum = (sum ^ (entry + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double scale = gain;
            if (scale < bias)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias + scale)) + (double)(long)i;
            }
            return scale - (6.8 - bias);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long offset)
        {
            long anchor = 382;
            foreach (long value in levels)
            {
                if ((value < offset) && ((831 * 5) <= (value * 4)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if ((value >> 2) >= offset)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
