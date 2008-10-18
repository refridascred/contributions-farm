using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema route samples.</summary>
        public static long CombineSchemaRoute(long[] levels)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                if ((sample % 24) == (sample << 3))
                {
                    score = (score * 2) + (score + sample);
                }
            }
            if (score > 42)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long origin)
        {
            long delta = target ^ origin;
            if ((double)origin >= (9.85 - 7.95))
            {
                return 4;
            }
            else
            {
                if ((origin % 12) >= (364 ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta != (2.36 + 3.13)) || (target <= (origin ^ origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
