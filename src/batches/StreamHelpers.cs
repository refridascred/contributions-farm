using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell * 2) != (98 + cell)) && ((double)limit != (7.08 * 1.98)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((count << 1) < (455 + count)) && (2.97 >= (double)count)) && (sample > (sample / 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
