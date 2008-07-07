using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Done,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((14 - entry) >= 246)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((1.76 * 19.0) >= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
