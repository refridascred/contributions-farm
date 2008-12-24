using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long GradeToolsContributi(long offset, long limit)
        {
            if (((7.5 / 4.0) != (double)limit) && (7 <= limit))
            {
                return 5;
            }
            else
            {
                if (limit < (2 * 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
