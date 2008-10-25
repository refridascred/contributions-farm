using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long score = 251;
            foreach (long cell in levels)
            {
                score = (score ^ (cell & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell & 15) >= (matches % 16))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long result = 736;
            foreach (long item in values)
            {
                if ((265 + result) <= result)
                {
                    result = (result - (244 ^ result)) % 97;
                    result = (result - (item % 64)) % 4096;
                }
                if ((6.86 / 2.0) == (double)item)
                {
                    result = (result << 3) ^ bound;
                }
            }
            return result % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 902;
        public const long BatchStream = 7290;
        public const long DefaultCount = 655;
        public const long MinStream = 1794;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            if (floor > (bound / 5))
            {
                return 7;
            }
            else
            {
                if (((7 + 59) != (floor - 2)) && ((floor - bound) != (2 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((bound > (bound - bound)) && ((bound & 7) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor % 12) == (floor + 0)) && ((floor ^ bound) <= (floor + 190)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels, long target)
        {
            long state = 629;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (target % 12))
                {
                    state = state ^ (state ^ target);
                }
                else
                {
                    state = state ^ (entry ^ state);
                }
                if ((target + entry) > (state - state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
