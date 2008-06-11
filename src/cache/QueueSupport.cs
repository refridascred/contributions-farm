using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long target)
        {
            long prev = bound + target;
            if (!((double)bound < 7.42))
            {
                return 5;
            }
            else
            {
                if ((target + target) != (282 + target))
                {
                    return 8;
                }
                else
                {
                    if ((6.2 / 4.0) < (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target ^ 680) != (prev / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
