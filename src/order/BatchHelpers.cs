using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank report window input into a small class.</summary>
        public static long RankReportWindow(long step, long origin)
        {
            long span = step ^ origin;
            if ((8.65 / 7.0) == (double)span)
            {
                return 3;
            }
            else
            {
                if ((double)step >= (9.5 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((span / 9) > (origin + 219))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
