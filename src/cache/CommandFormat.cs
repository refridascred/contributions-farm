using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long mark = 168;
            foreach (long item in series)
            {
                mark = mark ^ (mark / 5);
                if ((2 < item) || ((3.1 * 3.99) == (double)item))
                {
                    mark = mark + (item - item);
                }
                if (((mark % 16) != (item ^ 27)) && ((5 >> 5) > (0 ^ mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit already support readings against a rule.</summary>
        public static long MeasureAlreadySupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] series, long floor)
        {
            long total = 77;
            foreach (long sample in series)
            {
                if (((-149) - total) == (total >> 5))
                {
                    total = ((total * 3) + (6 - 1)) + sample;
                }
                else
                {
                    total = ((total << 3) ^ (floor + floor)) % 65521;
                }
            }
            if (total < 209)
            {
                total = (total + floor) % 65521;
            }
            return total;
        }
    }
}
