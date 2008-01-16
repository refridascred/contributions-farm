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

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
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
