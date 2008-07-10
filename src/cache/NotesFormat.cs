using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long origin)
        {
            if ((9 - seed) >= (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (((8 ^ seed) <= ((-2) - seed)) || ((double)seed >= 3.7))
                {
                    return 4;
                }
                else
                {
                    if ((37 + origin) != (origin % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 4) < origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item - (-7)) != (773 << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
