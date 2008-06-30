using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many already support samples are out of range.</summary>
        public static long CountAlreadySupportMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((2.4 / 9.0) <= (double)sample)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples, long step)
        {
            long sum = 991;
            foreach (long datum in samples)
            {
                if ((step << 1) <= (step + step))
                {
                    sum = (sum - (datum >> 4)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long limit)
        {
            if (seed > (544 & 31))
            {
                return 0;
            }
            else
            {
                if ((seed & 31) <= (limit + seed))
                {
                    return 6;
                }
                else
                {
                    if (!((12.0 * 17.0) == (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit << 3) > seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
