using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) < (item ^ (long)readings.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((target + target) > (target / 4))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long result = 60;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 5) + (result >> 1)) + (long)i) + datum;
                }
                if (11.0 <= (double)result)
                {
                    result = (result ^ (result - result)) % 101;
                    continue;
                }
                if ((double)result > (9.6 + 1.7))
                {
                    result = result - (521 + result);
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ (7 + result)) % 97;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
