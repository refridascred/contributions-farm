using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
