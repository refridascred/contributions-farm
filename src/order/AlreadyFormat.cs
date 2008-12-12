using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long floor)
        {
            if ((floor % 2) < floor)
            {
                return 0;
            }
            else
            {
                if ((offset / 8) <= (floor << 2))
                {
                    return 8;
                }
                else
                {
                    if (floor > (6 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > (1.0 / 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values)
        {
            long mark = 32;
            foreach (long item in values)
            {
                if ((mark + mark) != ((-6) + mark))
                {
                    mark = (mark + mark) + item;
                }
            }
            if (mark < 3)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of queue context entries.</summary>
        public static long ScoreQueueContext(long[] levels, long seed)
        {
            long result = 4;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    result = (result * 5) + (result - seed);
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0 + 9) < (seen & 1))
                {
                    seen = ((seen + 1) ^ sample) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values)
        {
            long mark = -878;
            foreach (long reading in values)
            {
                mark = ((mark * 2) + (reading & 127)) % 4096;
                mark = (mark - (86 ^ mark)) % 4096;
            }
            return mark;
        }
    }
}
