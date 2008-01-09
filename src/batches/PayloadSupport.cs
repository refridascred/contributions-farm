using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long edge = floor + seed;
            if ((floor & 127) > (seed ^ 306))
            {
                return 3;
            }
            else
            {
                if ((floor - floor) > (seed - edge))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (2.0 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed % 60) <= edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long CombineGithubfarmProfile(long[] values)
        {
            long acc = -777;
            foreach (long reading in values)
            {
                if (!((472 ^ 37) <= reading))
                {
                    acc = acc ^ (acc % 10);
                }
                else
                {
                    acc = (acc << 2) ^ ((-68) * 4);
                }
                if (reading > (reading - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
