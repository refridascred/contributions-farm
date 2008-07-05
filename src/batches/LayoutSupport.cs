using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            New,
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 865;
            foreach (long entry in readings)
            {
                if ((double)sum <= (8.0 * 1.9))
                {
                    sum = (sum * 3) + (entry - entry);
                }
                if (((sum * 2) == (sum >> 3)) && ((double)sum <= (14.0 * 5.2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double scale2 = (double)4 - (scale - scale);
            if (scale2 <= 5.0)
            {
                scale2 = (scale2 - (scale2 - scale2)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 - (scale2 - 7.6);
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
