using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if ((bound - offset) > offset)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) == (offset * 2))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 / 6.0) != (double)bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next report buffer value from a seed.</summary>
        public static long SeriesReportBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ 1) % 4096;
                score = score ^ ((-406) + 2);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a session payload reading by value.</summary>
        public static long FindSessionPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
