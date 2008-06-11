using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark - offset) ^ (long)i2;
                    mark = (mark + (offset + offset)) % 4096;
                }
                mark = (mark ^ mark) % 101;
                if ((mark % 24) >= offset)
                {
                    mark = (mark ^ ((long)i - mark)) % 255;
                    mark = ((mark << 2) ^ ((long)i ^ offset)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
