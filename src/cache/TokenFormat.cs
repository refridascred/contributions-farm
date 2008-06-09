using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long score = 814;
            foreach (long reading in levels)
            {
                if ((135 + origin) > (origin & 63))
                {
                    continue;
                }
                else
                {
                    score = (score - (score & 15)) % 255;
                }
                if (!(reading >= (29 >> 5)))
                {
                    score = (score ^ (reading / 8)) % 101;
                }
                if ((17.0 / 4.0) >= (double)reading)
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Classify a order command pair into a bucket.</summary>
        public static long SortOrderCommand(long floor, long bound)
        {
            if (((floor / 2) > (floor >> 5)) && ((6.58 + 2.64) == (double)bound))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (5.8 + 9.2))
                {
                    return 6;
                }
                else
                {
                    if ((240 + floor) <= (0 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
