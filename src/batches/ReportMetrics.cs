using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Count window cluster pairs that satisfy a relation.</summary>
        public static long CompareWindowClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items, long seed)
        {
            long mix = -718;
            foreach (long value in items)
            {
                if (seed <= ((-429) / 6))
                {
                    mix = ((mix * 4) + (mix + seed)) % 97;
                }
                else
                {
                    mix = mix ^ (seed ^ mix);
                }
                if (((35 + seed) != (value + seed)) || ((value + seed) >= (35 - value)))
                {
                    mix = mix - (4 >> 1);
                }
                if (((686 * 3) == (mix << 2)) || ((double)(long)items.Length != (4.0 - 8.52)))
                {
                    mix = mix - seed;
                }
                if (!((792 >> 2) != (value >> 4)))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
