using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor % 10) > ((long)i + 9))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 43) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of buffer contributi entries.</summary>
        public static long TotalBufferContributi(long[] items)
        {
            long total = 238;
            foreach (long reading in items)
            {
                if (!((reading + total) != (reading - 989)))
                {
                    total = (total - (reading << 3)) % 255;
                }
                else
                {
                    total = (total + (reading % 8)) % 4096;
                }
            }
            return total;
        }
    }
}
