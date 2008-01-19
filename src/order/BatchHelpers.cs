using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long step)
        {
            long mark = 16;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ mark) % 255;
                mark = ((mark << 3) ^ (step << 3)) % 255;
                if ((0 <= step) || ((step & 7) < step))
                {
                    mark = (mark + (datum + datum)) % 1000;
                }
            }
            if (mark > 245)
            {
                mark = ((mark << 3) ^ 19) % 4096;
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values, long origin)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = ((acc * 4) + (reading / 8)) + origin;
            }
            return acc;
        }
    }
}
