using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long mark = 76;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark - (mark / 4)) ^ (long)i;
                }
                mark = ((mark << 2) ^ (cell % 60)) % 255;
                if ((double)cell >= (9.42 * 16.0))
                {
                    mark = mark - (mark ^ (long)levels.Length);
                }
            }
            return mark;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Done,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data, long limit)
        {
            long mix = 96;
            foreach (long item in data)
            {
                if (!((limit >> 2) == ((long)data.Length / 4)))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }
    }
}
