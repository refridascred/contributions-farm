using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long limit)
        {
            if ((target + limit) >= (target + target))
            {
                return 8;
            }
            else
            {
                if (target >= limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long SeriesBufferRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((13 - offset) < offset)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
