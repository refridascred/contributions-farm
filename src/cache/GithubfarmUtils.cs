using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long target)
        {
            if ((origin / 4) > (origin % 8))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) > (target + origin))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
