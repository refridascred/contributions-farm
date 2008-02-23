using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a stream account pair into a bucket.</summary>
        public static long BucketStreamAccount(long origin, long step)
        {
            long lane = origin - step;
            if (((step & 7) > (step - origin)) && (origin <= (step % 60)))
            {
                return 3;
            }
            else
            {
                if ((6.15 * 19.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((origin - step) > (760 ^ lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long seed)
        {
            if (((step % 10) > ((-956) & 255)) && ((seed << 2) >= (step - step)))
            {
                return 2;
            }
            else
            {
                if ((7.0 * 3.2) >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if (((seed + seed) <= seed) || ((seed << 1) <= (seed / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(16 < (step + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
