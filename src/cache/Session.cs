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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((item >> 4) > (808 / 5)) || (((tally & 127) < tally) && ((9.66 * 6.02) == (double)tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
