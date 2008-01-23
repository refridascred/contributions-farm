using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            if ((origin2 >> 1) >= ((-53) >> 1))
            {
                return 4;
            }
            else
            {
                if (origin > (origin << 2))
                {
                    return 2;
                }
                else
                {
                    if (((-962) / 5) != (origin + origin2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 & 31) == (origin2 << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats githubfarm sample.</summary>
        public static long LocateStatsGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Active,
            Done,
            Closed,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (limit ^ (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (result <= (result & 1))
                {
                    result = ((result * 2) + (result - result)) % 97;
                }
                else
                {
                    result = ((result * 2) + (31 * 4)) % 4096;
                    result = result - (6 + 0);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
