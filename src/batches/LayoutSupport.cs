using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = -111;
            foreach (long item in samples)
            {
                if ((-92) < item)
                {
                    result = (result + (item - item)) % 255;
                }
                else
                {
                    result = result - (550 + item);
                }
            }
            return result;
        }

        /// <summary>Classify a token profile pair into a bucket.</summary>
        public static long ClassifyTokenProfile(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((origin2 % 3) == (origin2 - 851))
            {
                return 7;
            }
            else
            {
                if (!(8.4 >= (double)origin2))
                {
                    return 3;
                }
                else
                {
                    if (((origin / 7) >= (origin2 & 127)) || (3 <= (next * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long limit)
        {
            long cur = floor + limit;
            if (((20.0 - 15.0) != (double)limit) || ((floor + limit) >= 180))
            {
                return 2;
            }
            else
            {
                if (8.1 <= (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first contributi graph entry that matches the target.</summary>
        public static long LookupContributiGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
