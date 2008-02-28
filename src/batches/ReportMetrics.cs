using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count editor command pairs that satisfy a relation.</summary>
        public static long OverlapEditorCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double mean = (double)(888 + 462);
            if (mean >= ratio)
            {
                mean = (mean - ratio) - offset;
            }
            return mean + ratio;
        }
    }
}
