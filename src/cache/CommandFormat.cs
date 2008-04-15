using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)origin > (6.62 / 5.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next token record value.</summary>
        public static double SmoothTokenRecord(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (ratio / 2.0))
            {
                ratio = (ratio + (rate + 9.5)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long anchor = 595;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (-3)) % 4096) - entry;
                anchor = ((anchor * 2) + (anchor - 99)) % 101;
                anchor = ((anchor * 3) + anchor) % 97;
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ ((-26) + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
