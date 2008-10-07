using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double load = span;
            if (load > (load / 2.0))
            {
                load = load - 14.0;
            }
            else
            {
                load = load + (span + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.0) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items, long bound)
        {
            long anchor = 54;
            foreach (long sample in items)
            {
                anchor = (((anchor * 2) + (anchor + anchor)) ^ sample) + bound;
            }
            if (anchor < 608)
            {
                anchor = anchor ^ (anchor << 2);
            }
            return anchor % 4096;
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long AuditNotesPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-35) + hits) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
