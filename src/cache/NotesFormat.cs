using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((-250) < (step - hits)) || ((863 > hits) || ((double)hits < (4.04 / 6.0))))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
