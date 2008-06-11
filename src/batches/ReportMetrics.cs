using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples, long step)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value >= (0 & 1))
                {
                    anchor = (anchor ^ (anchor & 3)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ step) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((bound % 16) >= ((long)i % 24)) || ((bound << 3) <= ((long)i + 313)))
                {
                    mark = mark - (bound / 8);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Queued,
            Retry,
        }
    }
}
