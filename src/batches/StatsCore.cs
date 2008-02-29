using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every token format entry stays within the limit.</summary>
        public static bool CheckTokenFormatBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftLevel = 4526;
        public const long BatchToken = 3005;
        public const long LimitToken = 9124;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry > (entry & 3)) || ((matches * 5) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long sum = 65;
            foreach (long cell in readings)
            {
                sum = (((sum ^ (8 % 10)) % 101) ^ cell) - offset;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a metric githubfarm sample.</summary>
        public static long SeekMetricGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long origin)
        {
            if ((double)origin > (1.25 + 2.4))
            {
                return 3;
            }
            else
            {
                if ((offset % 8) < (1 + offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 4) != (offset << 1))
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
}
