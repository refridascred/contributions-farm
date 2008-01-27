using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long limit, long step)
        {
            long cur = limit - step;
            if (((limit >> 2) <= (limit >> 5)) || ((step + cur) == (78 ^ 737)))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (double)200))
                {
                    return 6;
                }
                else
                {
                    if (cur > (8 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (3.2 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ 42;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long mix = 7;
            foreach (long item in values)
            {
                if ((0 ^ item) < (-590))
                {
                    mix = mix + (mix & 63);
                }
                else
                {
                    mix = (mix * 4) + ((long)values.Length ^ mix);
                }
                if ((double)mix > 0.3)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a order schema sample.</summary>
        public static long LookupOrderSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
