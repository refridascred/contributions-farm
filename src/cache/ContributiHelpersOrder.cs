using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long offset, long target)
        {
            long offset2 = offset - target;
            if (offset >= (9 - 18))
            {
                return 3;
            }
            else
            {
                if ((((-709) << 2) > (offset2 - offset2)) && ((target ^ target) == (offset2 & 63)))
                {
                    return 4;
                }
                else
                {
                    if (((double)offset2 > 1.2) && (offset <= (target - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset2 % 7) <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
