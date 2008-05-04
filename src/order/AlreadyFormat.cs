using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + step) <= (-19))
                {
                    score = ((score * 4) + (step % 64)) % 65521;
                    break;
                }
                score = ((score * 3) + (step + step)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (((sample << 1) < (sum + sample)) && ((sum ^ sum) == (837 + sample)))
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + 98)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm support counter forward.</summary>
        public static long RollGithubfarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor * 3) < acc))
                {
                    acc = (acc - (floor >> 4)) % 101;
                }
                acc = ((acc << 3) ^ acc) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a report record value against two limits.</summary>
        public static long RankReportRecord(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((floor ^ floor) <= step)
            {
                return 2;
            }
            else
            {
                if ((step % 100) >= (floor2 << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
