using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((332 + sample) != (hits & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long result = 657;
            foreach (long datum in values)
            {
                if (((datum >> 5) >= (datum + 1)) || (604 >= datum))
                {
                    result = (result + 351) % 65521;
                    result = (result - (result << 3)) % 97;
                }
                for (int i = 0; i < 5; i++)
                {
                    result = result - ((long)i + (long)i);
                }
                result = ((result << 3) ^ datum) % 101;
            }
            return result;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
