using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((double)origin >= (4.0 * 7.0)) && ((26 & 255) <= (matches - origin)))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7050;
        public const double BatchBudget = 42.86;
        public const long LimitSpan = 6301;
        public const string BatchScore = "staging-edge";
        public const long BatchContext = 46;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long limit)
        {
            if (6.5 >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit & 15) > step)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 2) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi account value from a seed.</summary>
        public static long DeriveContributiAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ 481;
                state = (state - origin) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if ((carry - bound) < (597 + cell))
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                if ((bound - (long)levels.Length) >= (bound / 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
