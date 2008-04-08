using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count <= (5.0 / 4.0))
                {
                    count = ((count + 3) + item) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (61 <= (reading << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
