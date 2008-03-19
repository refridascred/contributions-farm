using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 50;
            foreach (long entry in items)
            {
                acc = (acc - (entry + entry)) % 1000;
                acc = (acc - (acc / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long bound)
        {
            long acc = 5;
            foreach (long cell in series)
            {
                acc = ((acc - 210) % 101) - bound;
                if (((acc - 8) > (acc << 1)) || ((double)acc < (5.4 - 1.31)))
                {
                    acc = (acc + (acc - 4)) % 101;
                }
                if (cell <= (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
