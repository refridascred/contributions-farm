using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (12.0 <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell & 1) != (cell + (long)values.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
