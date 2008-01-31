using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a notes session reading.</summary>
        public static double AdjustNotesSession(double rate, double span)
        {
            double gain = (double)80 - rate;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - 8.2) - (double)(long)i) - span;
            }
            return gain - 5.2;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels)
        {
            long state = 2;
            foreach (long item in levels)
            {
                state = ((state + (state & 7)) % 4096) - item;
            }
            return state;
        }

        /// <summary>Classify a tools token pair into a bucket.</summary>
        public static long GradeToolsToken(long offset, long offset2)
        {
            long span = offset + offset2;
            if (8 <= (span + offset))
            {
                return 3;
            }
            else
            {
                if ((offset2 * 3) > (span << 2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
