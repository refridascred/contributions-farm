using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long floor)
        {
            long offset = limit + floor;
            if ((offset >> 5) == (floor + floor))
            {
                return 8;
            }
            else
            {
                if (((double)floor < (6.0 / 5.0)) && ((offset & 15) >= floor))
                {
                    return 5;
                }
                else
                {
                    if ((limit + floor) >= (floor >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - floor) > (offset / 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order record readings against a rule.</summary>
        public static long TallyOrderRecordMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((322 << 3) < (cell >> 1))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            if ((2.5 <= (double)bound) && (offset > (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((7 / 8) <= offset) && (offset >= (offset << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 23) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                sum = ((sum + (sum % 16)) % 65521) ^ item;
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum + ((long)i - (long)i)) % 97;
                    sum = ((sum << 3) ^ (sum ^ 95)) % 101;
                }
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long anchor = 4;
            foreach (long sample in series)
            {
                if (((5.4 / 9.0) < (double)anchor) || ((anchor % 16) <= anchor))
                {
                    anchor = (((anchor << 3) ^ (0 << 2)) % 1000) ^ sample;
                }
            }
            return anchor;
        }
    }
}
