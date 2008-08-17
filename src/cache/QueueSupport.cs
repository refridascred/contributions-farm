using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long ClassifyStreamAlready(long bound, long limit)
        {
            if (limit > (limit << 2))
            {
                return 7;
            }
            else
            {
                if ((bound % 60) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long seed)
        {
            long bound2 = bound + seed;
            if ((double)bound < (7.0 - 4.0))
            {
                return 5;
            }
            else
            {
                if ((bound2 * 4) > (bound2 - bound))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 6) < (699 % 24))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound2 % 7) < bound2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
