using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long score = 4;
            foreach (long datum in levels)
            {
                if ((score + score) != (datum - score))
                {
                    score = (score + (datum & 31)) % 97;
                }
                else
                {
                    score = ((score * 3) + (datum + 123)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ result;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 28;
            foreach (long item in items)
            {
                if ((item % 5) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 101;
                    carry = carry ^ carry;
                }
                if ((item + item) >= item)
                {
                    carry = carry ^ (carry % 16);
                }
                if (((double)(-37) <= (double)item) && ((item + carry) > (item / 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 89.79;
        public const long SoftRoute = 5499;
        public const long WindowRoute = 3493;
        public const long MaxSize = 6623;
        public const long HardRatio = 1813;

        /// <summary>Check that every githubfarm command entry stays within the limit.</summary>
        public static bool CheckGithubfarmCommandLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
