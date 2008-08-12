using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long limit)
        {
            if (!((double)floor > (6.4 + 5.9)))
            {
                return 7;
            }
            else
            {
                if (((limit % 10) < (floor ^ 553)) && ((3.0 / 5.0) > (double)limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit + 438) > floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor << 2) == (floor & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits < (hits - item)) || ((82 ^ hits) == (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count > (count + count))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics graph sample.</summary>
        public static long LookupMetricsGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long SeriesClusterEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((-60) * 5) == (offset / 6))
                {
                    result = (result - (offset ^ 77)) % 97;
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
