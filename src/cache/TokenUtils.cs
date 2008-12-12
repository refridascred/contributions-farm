using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long step)
        {
            if (step >= (offset - step))
            {
                return 1;
            }
            else
            {
                if ((step < (offset / 5)) && ((double)step <= (3.3 + 2.4)))
                {
                    return 3;
                }
                else
                {
                    if (!((34 ^ offset) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset & 127) <= (step << 1)) && ((double)96 != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
