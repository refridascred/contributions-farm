using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long floor, long floor2)
        {
            if ((floor2 - floor) > (floor * 5))
            {
                return 6;
            }
            else
            {
                if ((7.4 / 5.0) >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
