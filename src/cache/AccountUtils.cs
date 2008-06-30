using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if (((cell % 16) >= (cell << 2)) && ((cell & 15) <= (acc / 2)))
                {
                    acc = ((acc << 3) ^ (cell * 4)) % 255;
                }
                else
                {
                    acc = acc - (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a filter payload counter forward.</summary>
        public static long StepFilterPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((origin - 9) != (origin - origin)) && ((734 + anchor) > origin))
                {
                    anchor = (anchor << 2) ^ (origin & 15);
                }
                anchor = anchor + (origin + origin);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
