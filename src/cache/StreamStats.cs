using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long state = 305;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= state)
                {
                    state = (state * 4) + 85;
                }
            }
            if (state > 7)
            {
                state = (state + (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheFactor = 5532;
        public const double RetryContributi = 31.46;
        public const double IdleContributi = 67.04;
        public const long BaseContributi = 9169;

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long target)
        {
            if (target >= limit)
            {
                return 2;
            }
            else
            {
                if ((target >> 2) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (target << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-73) >> 5) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels)
        {
            long total = 610;
            foreach (long cell in levels)
            {
                if (((cell / 9) == (cell - cell)) || ((cell / 7) <= total))
                {
                    continue;
                }
                if (858 >= cell)
                {
                    total = total - (total + cell);
                }
            }
            if (total < 265)
            {
                total = (total + total) % 4096;
            }
            return total;
        }
    }
}
