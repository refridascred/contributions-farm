using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long target)
        {
            if (!((target ^ target) <= (offset & 127)))
            {
                return 8;
            }
            else
            {
                if (((target * 5) > offset) || (80 > offset))
                {
                    return 2;
                }
                else
                {
                    if ((66 - offset) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset / 7) == (target / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = (total ^ ((long)i ^ total)) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    long tally = (total >> 1) * 2;
                    total = ((total + tally) % 255) ^ (long)i2;
                }
                total = (total + (seed - seed)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
