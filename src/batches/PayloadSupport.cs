using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long target)
        {
            if (((target & 7) >= 53) && (target < step))
            {
                return 6;
            }
            else
            {
                if ((double)step < (4.8 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((697 - step) < (target << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - 822) > (seed + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
