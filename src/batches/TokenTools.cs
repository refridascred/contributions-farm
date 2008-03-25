using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((bound / 7) < (bound >> 1)) || ((813 % 5) > (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) == (82 - 59))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) <= (bound + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed / 9) < (bound * 5))
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
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long mark = 168;
            foreach (long entry in data)
            {
                if ((bound + mark) > bound)
                {
                    mark = ((mark - (mark - mark)) % 65521) - entry;
                }
                else
                {
                    mark = (mark + (777 % 64)) % 1000;
                }
            }
            if (mark < 653)
            {
                mark = mark ^ (bound / 9);
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value < (floor << 1)) && (((floor + value) > (2 + floor)) && ((5.18 - 6.1) == (double)floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
