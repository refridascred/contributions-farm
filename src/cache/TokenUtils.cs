using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long AuditSessionQueueGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((8.33 - 17.0) > (double)count)
                {
                    count = ((count + 2) + sample) + step;
                }
            }
            return count;
        }

        /// <summary>Match up record filter samples.</summary>
        public static long MatchRecordFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
