using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
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
