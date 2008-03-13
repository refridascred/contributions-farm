using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long seed)
        {
            if (seed > (5 * 4))
            {
                return 3;
            }
            else
            {
                if ((seed % 5) != (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((seed + step) > 9)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 / 5.0) >= (double)step)
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (4 <= count)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
