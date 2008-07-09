using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every editor window entry stays within the limit.</summary>
        public static bool CheckEditorWindowRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((388 > origin) || ((double)origin != (2.0 - 3.87)))
            {
                return 6;
            }
            else
            {
                if (33 <= (lane - limit))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 + 15.0) > (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 5) != (3 / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile githubfarm readings.</summary>
        public static long ScoreProfileGithubfarm(long[] readings, long origin)
        {
            long sum = 474;
            foreach (long reading in readings)
            {
                if (!((double)origin > 7.4))
                {
                    sum = sum - (sum - (long)readings.Length);
                }
                if ((reading >> 3) == (origin ^ 6))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 3) ^ (859 + sum);
            }
            return sum;
        }
    }
}
