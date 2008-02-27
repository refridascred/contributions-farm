using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 3) ^ sum;
                sum = sum - (71 + offset);
                sum = sum + offset;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
