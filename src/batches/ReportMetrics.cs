using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 577;
            foreach (long item in data)
            {
                mark = (((mark - (237 % 64)) % 4096) ^ item) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Iterate the commits queue series from a seed.</summary>
        public static long StepCommitsQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (mix + mix);
                mix = (mix * 4) + (seed * 2);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Ready,
            Draft,
            Done,
        }
    }
}
