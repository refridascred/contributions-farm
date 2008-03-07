using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (((long)values.Length - score) == (60 + 644))
                {
                    score = score + reading;
                }
                if ((reading << 2) > 538)
                {
                    score = (score ^ (60 << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit notes account readings against a rule.</summary>
        public static long MeasureNotesAccountHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (2.57 > (double)limit)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a order support value against two limits.</summary>
        public static long RankOrderSupport(long bound, long offset)
        {
            if ((offset & 1) < bound)
            {
                return 1;
            }
            else
            {
                if (((bound >> 2) <= (offset + offset)) || (offset < (offset & 255)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings)
        {
            long state = 717;
            foreach (long item in readings)
            {
                if ((9.05 + 3.34) <= (double)item)
                {
                    state = (state ^ state) % 1000;
                }
            }
            return state;
        }
    }
}
