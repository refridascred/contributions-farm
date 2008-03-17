using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long target)
        {
            long gap = offset ^ target;
            if (((gap + 864) >= (6 ^ target)) || ((offset + offset) < (gap * 2)))
            {
                return 2;
            }
            else
            {
                if ((gap - offset) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((target >= 47) && ((double)offset < (16.0 / 6.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((789 + offset) > offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((8.76 / 2.0) < (double)sample)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
