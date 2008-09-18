using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Failed,
            Ready,
            Pending,
            Done,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen / 2) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
