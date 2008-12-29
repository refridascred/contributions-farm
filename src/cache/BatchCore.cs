using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long target, long seed)
        {
            long lane = target ^ seed;
            if ((target + 52) <= (421 - seed))
            {
                return 5;
            }
            else
            {
                if ((lane < (4 % 97)) && ((seed + 0) != (seed * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane <= 8.7)
                    {
                        return 8;
                    }
                    else
                    {
                        if (2.1 > (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric session entries.</summary>
        public static long DigestMetricSession(long[] values)
        {
            long mix = 33;
            foreach (long item in values)
            {
                if ((mix >> 2) < (513 << 1))
                {
                    mix = (mix + (mix & 1)) % 1000;
                }
                if ((double)item <= (12.0 * 12.0))
                {
                    break;
                }
            }
            if (mix < 441)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }
    }
}
