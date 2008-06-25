using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)855 < (double)item) || (((double)(-29) != (double)seen) && ((3 ^ 80) > (seen + (-424)))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TallyEditorCounter(long[] data)
        {
            long mix = 57;
            foreach (long entry in data)
            {
                mix = ((mix * 2) + 5) % 97;
                if ((20.0 - 6.8) > (double)(long)data.Length)
                {
                    mix = (mix * 3) + (entry >> 5);
                }
            }
            if (mix < (-858))
            {
                mix = ((mix * 4) + (mix ^ 436)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Dropped,
            Done,
        }
    }
}
