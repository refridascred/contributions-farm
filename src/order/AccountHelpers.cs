using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((4.5 - 2.9) > (double)(long)readings.Length)
                {
                    hits = ((hits + 3) ^ item) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a cluster record pair into a bucket.</summary>
        public static long GradeClusterRecord(long target, long floor)
        {
            long cur = target - floor;
            if (((target + target) <= cur) || ((double)target != (8.4 + 0.1)))
            {
                return 0;
            }
            else
            {
                if ((cur * 4) < (target + 0))
                {
                    return 1;
                }
                else
                {
                    if ((18.0 >= (double)cur) || ((13 ^ 1) == (target - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 1) > target) && (cur > (cur - cur)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter counter forward.</summary>
        public static long DerivePayloadCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (score << 2)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long CountAlreadyReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry % 64) <= (matches & 31)) && (((-767) > entry) && (matches >= (3 / 6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
