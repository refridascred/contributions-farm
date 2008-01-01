using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a order layout pair into a bucket.</summary>
        public static long BucketOrderLayout(long limit, long floor)
        {
            if (floor >= (215 - limit))
            {
                return 7;
            }
            else
            {
                if ((limit + floor) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)804 <= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((-605) > (limit + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((double)total != (3.0 - 1.5)) || ((total & 63) == (total + origin)))
                {
                    total = ((total << 3) ^ (total >> 3)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a checks profile sample.</summary>
        public static long FindChecksProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
