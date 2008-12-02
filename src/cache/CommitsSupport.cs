using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank githubfarm layout input into a small class.</summary>
        public static long SortGithubfarmLayout(long limit, long origin)
        {
            long delta = limit - origin;
            if ((origin + limit) > (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)delta < (0.1 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 7872;
        public const long BatchOrder = 5990;
        public const string MinOrder = "standard-1";
        public const string SoftOrder = "legacy-v2";

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 4;
            foreach (long entry in readings)
            {
                if (!((553 + carry) >= 436))
                {
                    carry = ((carry ^ (9 / 4)) % 65521) + entry;
                }
                else
                {
                    carry = ((carry * 3) + 267) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry * 2) + (carry - carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 3) <= (matches >> 1)) || !((floor * 4) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
