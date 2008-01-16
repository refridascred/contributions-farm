using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Active,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long state = 806;
            foreach (long item in readings)
            {
                if (item <= (item + state))
                {
                    state = ((state * 5) + (2 * 4)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (step * 2)) % 101;
                }
            }
            return state % 97;
        }
    }
}
