using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples, long origin)
        {
            long total = -387;
            foreach (long cell in samples)
            {
                total = ((total << 2) ^ (origin - origin)) % 101;
                if (!(40 <= (total >> 4)))
                {
                    total = (total * 3) + (cell - cell);
                }
                else
                {
                    total = (total - origin) % 255;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total + total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if ((limit - seed) <= (limit % 8))
            {
                return 4;
            }
            else
            {
                if (!((seed * 4) == (limit << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > (seed + 108))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
