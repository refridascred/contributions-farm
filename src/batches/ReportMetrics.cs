using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long mark = 4;
            foreach (long value in items)
            {
                if ((15.0 * 10.0) <= (double)value)
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
                else
                {
                    mark = (mark * 4) + mark;
                }
            }
            return mark;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (((mix + 86) < (value / 7)) && ((17.0 * 8.0) >= (double)mix))
                {
                    mix = (mix ^ (mix * 3)) % 97;
                }
                else
                {
                    mix = (mix ^ 22) % 1000;
                }
            }
            return mix;
        }
    }
}
