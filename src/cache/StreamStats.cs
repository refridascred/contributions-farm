using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Paused,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Match up already commits samples.</summary>
        public static long MatchAlreadyCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long origin)
        {
            if ((origin - 0) > origin)
            {
                return 0;
            }
            else
            {
                if ((floor < (4 / 6)) || ((origin - 3) == (floor ^ origin)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (5.3 * 0.59))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen << 2) < (datum >> 5))
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
