using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((19 / 6) != (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (6 ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if ((double)limit < 6.1)
            {
                return 4;
            }
            else
            {
                if ((offset - offset) >= (offset + limit))
                {
                    return 2;
                }
                else
                {
                    if (((limit << 3) == (offset + limit)) && ((13.0 - 2.35) == (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset != (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 8777;
        public const long LimitSize = 6914;
        public const long WindowDepth = 2500;
        public const double DefaultDepth = 68.24;
        public const long HardContext = 2278;

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long limit)
        {
            long sum = 4;
            foreach (long reading in items)
            {
                if (((double)reading > (3.1 * 3.0)) && (38 <= (reading + sum)))
                {
                    sum = ((sum - ((-5) >> 3)) % 101) - limit;
                }
                else
                {
                    sum = sum - (sum + 339);
                }
            }
            if (sum < 81)
            {
                sum = sum + sum;
            }
            return sum % 1000;
        }
    }
}
