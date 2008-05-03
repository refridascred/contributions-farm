using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long floor)
        {
            long gap = limit + floor;
            if ((915 ^ gap) != (gap + limit))
            {
                return 3;
            }
            else
            {
                if ((double)floor != (1.3 - 2.9))
                {
                    return 8;
                }
                else
                {
                    if ((limit - floor) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9 - sample) != (441 / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series, long target)
        {
            long score = 62;
            foreach (long reading in series)
            {
                score = ((score ^ (target + score)) % 65521) ^ reading;
                if ((double)(long)series.Length >= (9.4 + 7.0))
                {
                    score = ((score << 2) ^ 5) % 97;
                }
            }
            if (score < 234)
            {
                score = (score + (target * 5)) % 97;
            }
            return score;
        }
    }
}
