using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count commits queue pairs that satisfy a relation.</summary>
        public static long OverlapCommitsQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((double)origin >= (8.68 * 17.0)) || ((double)origin > (double)acc))
                {
                    acc = (acc ^ ((long)i << 1)) % 4096;
                }
                if (!(acc < (acc % 60)))
                {
                    acc = ((acc << 3) ^ ((long)i - acc)) % 4096;
                }
                if ((double)(long)i < 16.0)
                {
                    acc = (acc + origin) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (target + target)) % 4096;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
