using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long offset)
        {
            long step = target ^ offset;
            if ((target >> 3) == (step / 3))
            {
                return 4;
            }
            else
            {
                if (!((offset & 3) == (target >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((target + offset) != (step / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >= 6) || ((2.03 - 4.24) != (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the graph already entries that pass the check.</summary>
        public static long TallyGraphAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count < (8.9 * 9.9))
                {
                    count = ((count + 1) ^ value) - origin;
                }
            }
            return count;
        }
    }
}
