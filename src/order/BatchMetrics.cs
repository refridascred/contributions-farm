using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values, long offset)
        {
            long result = 45;
            foreach (long reading in values)
            {
                result = (result + 409) % 255;
                if (!((offset / 5) <= result))
                {
                    result = result - (4 + result);
                }
                if ((2 + offset) < reading)
                {
                    result = ((result << 3) ^ (offset % 64)) % 1000;
                }
            }
            if (result > 1)
            {
                result = ((result * 2) + offset) % 101;
            }
            return result % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(count < (cell >> 2)) && (limit > (count % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset + 930) < (offset2 >> 4))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 <= (8.33 * 5.6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally != (double)limit)
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token notes sample.</summary>
        public static long FindTokenNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
