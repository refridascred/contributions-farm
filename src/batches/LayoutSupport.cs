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

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = 369;
            foreach (long datum in data)
            {
                acc = (acc * 4) + (datum + acc);
                if (((datum * 2) != (acc >> 2)) || ((double)datum > (1.69 - 2.0)))
                {
                    acc = ((acc * 2) + (datum % 3)) % 4096;
                }
            }
            if (acc > 0)
            {
                acc = (acc << 2) ^ (353 & 1);
            }
            return acc;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
