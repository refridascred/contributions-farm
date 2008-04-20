using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every account support entry stays within the limit.</summary>
        public static bool GuardAccountSupportRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (8.8 <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
