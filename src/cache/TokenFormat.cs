using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a profile cache value against two limits.</summary>
        public static long ClassifyProfileCache(long seed, long limit)
        {
            if ((limit / 2) == (seed << 3))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) < limit)
                {
                    return 3;
                }
                else
                {
                    if (seed < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
