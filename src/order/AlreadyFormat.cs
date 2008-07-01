using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 8799;
        public const long SoftFactor = 8351;
        public const long SoftCount = 4463;

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 7) >= (offset + offset))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((count ^ count) <= (count + limit)) && ((15.0 / 9.0) <= (double)limit)) || ((4.7 / 8.0) > (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if (!((472 * 5) > floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) == (floor % 60))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long offset)
        {
            if (1.67 < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset + 51) > offset)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
